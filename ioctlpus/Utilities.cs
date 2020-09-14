using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioctlpus
{
    class Utilities
    {
        // CRC16 code taken from Sanity Free Coding (2006-12-15)
        // URL: http://www.sanity-free.com/134/standard_crc_16_in_csharp.html
        // License: CC BY-NC-SA 3.0
        public class CRC16
        {
            const ushort polynomial = 0xA001;
            ushort[] table = new ushort[256];

            public CRC16()
            {
                ushort value;
                ushort temp;
                for (ushort i = 0; i < table.Length; ++i)
                {
                    value = 0;
                    temp = i;
                    for (byte j = 0; j < 8; ++j)
                    {
                        if (((value ^ temp) & 0x0001) != 0)
                        {
                            value = (ushort)((value >> 1) ^ polynomial);
                        }
                        else
                        {
                            value >>= 1;
                        }
                        temp >>= 1;
                    }
                    table[i] = value;
                }
            }

            public ushort ComputeChecksum(byte[] bytes)
            {
                ushort crc = 0;
                for (int i = 0; i < bytes.Length; ++i)
                {
                    byte index = (byte)(crc ^ bytes[i]);
                    crc = (ushort)((crc >> 8) ^ table[index]);
                }
                return crc;
            }

            public byte[] ComputeChecksumBytes(byte[] bytes)
            {
                ushort crc = ComputeChecksum(bytes);
                return BitConverter.GetBytes(crc);
            }
        }

        public class NativeMethods
        {
            public const int EM_SETCUEBANNER = 0x1501;

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

            public const Int32 DIGCF_PRESENT = 2;
            public const Int32 DIGCF_DEVICEINTERFACE = 0x10;

            [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern IntPtr SetupDiGetClassDevs(
                ref Guid ClassGuid,
                IntPtr Enumerator,
                IntPtr hwndParent,
                Int32 Flags);

            public struct SP_DEVICE_INTERFACE_DATA
            {
                public int cbSize;
                public Guid InterfaceClassGuid;
                public int Flags;
                public IntPtr Reserved;
            };

            [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern Boolean SetupDiEnumDeviceInterfaces(
                IntPtr DeviceInfoSet,
                IntPtr DeviceInfoData,
                ref Guid InterfaceClassGuid,
                Int32 MemberIndex,
                ref SP_DEVICE_INTERFACE_DATA DeviceInterfaceData);

            [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern Boolean SetupDiGetDeviceInterfaceDetail(
                IntPtr DeviceInfoSet,
                ref SP_DEVICE_INTERFACE_DATA DeviceInterfaceData,
                IntPtr DeviceInterfaceDetailData,
                int DeviceInterfaceDetailDataSize,
                ref int RequiredSize,
                IntPtr DeviceInfoData);

            [DllImport("setupapi.dll", SetLastError = true)]
            public static extern int SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern SafeFileHandle CreateFile(
                string lpFileName,
                [MarshalAs(UnmanagedType.U4)] FileAccess dwDesiredAccess,
                [MarshalAs(UnmanagedType.U4)] FileShare dwShareMode,
                IntPtr lpSecurityAttributes,
                [MarshalAs(UnmanagedType.U4)] FileMode dwCreationDisposition,
                [MarshalAs(UnmanagedType.U4)] FileAttributes dwFlagsAndAttributes,
                IntPtr hTemplateFile);

            [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool DeviceIoControl(
                SafeFileHandle hDevice,
                uint ioControlCode,
                IntPtr inBuffer,
                uint nInBufferSize,
                byte[] outBuffer,
                uint nOutBufferSize,
                ref uint pBytesReturned,
                IntPtr overlapped);

            [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern bool DeviceIoControl(
                SafeFileHandle hDevice,
                uint ioControlCode,
                byte[] inBuffer,
                uint nInBufferSize,
                byte[] outBuffer,
                uint nOutBufferSize,
                ref uint pBytesReturned,
                IntPtr overlapped);
            
            [DllImport("kernel32.dll")]
            public static extern bool CloseHandle(SafeFileHandle hObject);

            [DllImport("msvcrt.dll", EntryPoint = "memset", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
            public static extern IntPtr MemSet(IntPtr dest, int c, int count);
        }

        public class IOCTL
        {
            public static string ResolveDeviceInstanceGUID(Guid guid)
            {
                IntPtr deviceInfoSet = NativeMethods.SetupDiGetClassDevs(
                    ref guid,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    NativeMethods.DIGCF_PRESENT | NativeMethods.DIGCF_DEVICEINTERFACE);

                if (deviceInfoSet != IntPtr.Zero)
                {
                    Int32 memberIndex = 0;
                    NativeMethods.SP_DEVICE_INTERFACE_DATA deviceInterfaceData = new NativeMethods.SP_DEVICE_INTERFACE_DATA();
                    deviceInterfaceData.cbSize = Marshal.SizeOf(deviceInterfaceData);

                    bool isEnumeratedDeviceInterfaces = NativeMethods.SetupDiEnumDeviceInterfaces(
                        deviceInfoSet,
                        IntPtr.Zero,
                        ref guid,
                        memberIndex,
                        ref deviceInterfaceData);

                    if (isEnumeratedDeviceInterfaces)
                    {
                        // Request a structure with the device path name.
                        int bufferSize = 0;
                        IntPtr detailDataBuffer;

                        // Determine the buffer size.
                        bool hasDeviceInterfaceDetail = NativeMethods.SetupDiGetDeviceInterfaceDetail(
                            deviceInfoSet,
                            ref deviceInterfaceData,
                            IntPtr.Zero,
                            0,
                            ref bufferSize,
                            IntPtr.Zero);

                        detailDataBuffer = Marshal.AllocHGlobal(bufferSize);
                        Marshal.WriteInt32(detailDataBuffer, (IntPtr.Size == 4) ? (4 + Marshal.SystemDefaultCharSize) : 8);

                        // Request the structure again now that the buffer size has been determined.
                        hasDeviceInterfaceDetail = NativeMethods.SetupDiGetDeviceInterfaceDetail(
                            deviceInfoSet,
                            ref deviceInterfaceData,
                            detailDataBuffer,
                            bufferSize,
                            ref bufferSize,
                            IntPtr.Zero);

                        if (hasDeviceInterfaceDetail)
                        {
                            IntPtr ptrDevicePathName = new IntPtr(detailDataBuffer.ToInt32() + 4);
                            string devicePathName = Marshal.PtrToStringAuto(ptrDevicePathName);
                            Marshal.FreeHGlobal(detailDataBuffer);
                            NativeMethods.SetupDiDestroyDeviceInfoList(deviceInfoSet);
                            return devicePathName;
                        }
                        else
                        {
                            throw new ArgumentException("Could not resolve symbolic link from GUID.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Could not resolve symbolic link from GUID.");
                    }
                }
                else
                {
                    throw new ArgumentException("Could not resolve symbolic link from GUID.");
                }
            }

            public static bool IsValidDevicePath(string devicePath)
            {
                SafeFileHandle handle = NativeMethods.CreateFile(
                    devicePath,
                    0,
                    FileShare.ReadWrite,
                    IntPtr.Zero,
                    FileMode.Open,
                    FileAttributes.Normal,
                    IntPtr.Zero);

                bool isValid = !handle.IsInvalid;
                handle.Close();
                return isValid;
            }
        }
    }
}
