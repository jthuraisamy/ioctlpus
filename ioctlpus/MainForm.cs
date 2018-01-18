using Be.Windows.Forms;
using BrightIdeasSoftware;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ioctlpus.Utilities.NativeMethods;
using static ioctlpus.Utilities.IOCTL;
using System.Drawing;

namespace ioctlpus
{
    public partial class MainForm : Form
    {
        private List<Request> requests = new List<Request>();
        private Utilities.CRC16 CRC16 = new Utilities.CRC16();

        public MainForm()
        {
            InitializeComponent();

            // Add placeholder text to filters textbox.
            SendMessage(tbFilters.Handle, EM_SETCUEBANNER, 0, "Filters (e.g. 9C412000 br=64 !ec=C000000D)");

            // Setup HexBoxes.
            InitializeHexBox(hbInput, (int)nudInputSize.Value);
            InitializeHexBox(hbOutput, (int)nudOutputSize.Value);

            // Setup TreeListView.
            InitializeTreeListView();

            // Setup initial parameters.
            tbDevicePath.Text = @"\\.\PhysicalDrive0";
            tbIOCTL.Text = "70000";
        }

        /// <summary>
        /// Initialize the given buffer view.
        /// </summary>
        /// <param name="hexBox"></param>
        /// <param name="size"></param>
        private void InitializeHexBox(HexBox hexBox, int size)
        {
            hexBox.ColumnInfoVisible = true;
            hexBox.VScrollBarVisible = true;
            hexBox.LineInfoVisible = true;
            hexBox.StringViewVisible = true;
            DynamicByteProvider dbpData = new DynamicByteProvider(new byte[size]);
            hexBox.ByteProvider = dbpData;
        }

        /// <summary>
        /// Initialize the Request History views.
        /// </summary>
        private void InitializeTreeListView()
        {
            // Add colours to request rows.
            tlvRequestHistory.FormatRow += (sender, eventArgs) =>
            {
                Request transmission = (Request)eventArgs.Model;
                if (transmission.IsFavourite)
                    eventArgs.Item.BackColor = System.Drawing.Color.LightYellow;
                else if (transmission.ReturnValue > 0)
                    eventArgs.Item.BackColor = System.Drawing.Color.MistyRose;
            };

            // Rename requests when double-clicked or F2 is pressed.
            tlvRequestHistory.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;

            // How to identify if a row has children.
            tlvRequestHistory.CanExpandGetter = delegate (Object tx)
            {
                return ((Request)tx).Children.Count > 0;
            };

            // Where row children are located.
            tlvRequestHistory.ChildrenGetter = delegate (Object tx)
            {
                return ((Request)tx).Children;
            };

            // Populate HexBoxes when the selection changes.
            tlvRequestHistory.SelectionChanged += (sender, eventArgs) =>
            {
                if (tlvRequestHistory.SelectedIndex == -1) return;

                Request tx = (Request)tlvRequestHistory.SelectedObject;

                tbDevicePath.Text = tx.DevicePath;
                tbIOCTL.Text = tx.IOCTL.ToString("X");
                nudInputSize.Value = tx.PreCallInput.Length;
                nudOutputSize.Value = tx.PostCallOutput.Length;

                DynamicByteProvider dbpDataInput = new DynamicByteProvider(tx.PreCallInput);
                hbInput.ByteProvider = dbpDataInput;

                DynamicByteProvider dbpDataOutput = new DynamicByteProvider(tx.PostCallOutput);
                hbOutput.ByteProvider = dbpDataOutput;
            };
        }

        /// <summary>
        /// Validate provided device path.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDevicePath_TextChanged(object sender, EventArgs e)
        {
            Guid guid;
            if (Guid.TryParse(tbDevicePath.Text, out guid))
            {
                Point toolTipCoords = tbDevicePath.Location;
                toolTipCoords.X += 20;
                toolTipCoords.Y -= 4;

                try
                {
                    string devicePath = ResolveDeviceInstanceGUID(guid);
                    tbDevicePath.Text = devicePath;
                    toolTip.Show("Resolved device instance GUID to symbolic link.", tbDevicePath, toolTipCoords, 3000);
                }
                catch (ArgumentException exception)
                {
                    toolTip.Show(exception.Message, tbDevicePath, toolTipCoords, 5000);
                }
            }

            if (IsValidDevicePath(tbDevicePath.Text))
                tbDevicePath.BackColor = System.Drawing.Color.Honeydew;
            else
                tbDevicePath.BackColor = System.Drawing.Color.MistyRose;
        }

        /// <summary>
        /// Validate that provided IOCTL is legitimate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIOCTL_TextChanged(object sender, EventArgs e)
        {
            Point toolTipCoords = tbIOCTL.Location;
            toolTipCoords.X -= 89;
            toolTipCoords.Y -= 27;

            uint ioctl;
            if (!UInt32.TryParse(tbIOCTL.Text, System.Globalization.NumberStyles.HexNumber, null, out ioctl))
            {
                tbIOCTL.BackColor = System.Drawing.Color.MistyRose;
                btnSend.Enabled = false;
                toolTip.Show("IOCTL codes must be in hexadecimal format.", tbIOCTL, toolTipCoords, 3000);
            }
            else
            {
                tbIOCTL.BackColor = System.Drawing.Color.White;
                btnSend.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SafeFileHandle sfh = CreateFile(
                tbDevicePath.Text,
                0,
                FileShare.ReadWrite,
                IntPtr.Zero,
                FileMode.Open,
                FileAttributes.Normal,
                IntPtr.Zero);

            uint returnedBytes = 0;
            uint inputSize = (uint)nudInputSize.Value;
            uint outputSize = (uint)nudOutputSize.Value;

            long hbInputLength = ((DynamicByteProvider)hbInput.ByteProvider).Length;
            byte[] inputBuffer = new byte[inputSize];
            MemSet(Marshal.UnsafeAddrOfPinnedArrayElement(inputBuffer, 0), 0, (int)hbInputLength);

            long hbOutputLength = ((DynamicByteProvider)hbOutput.ByteProvider).Length;
            byte[] outputBuffer = new byte[outputSize];
            MemSet(Marshal.UnsafeAddrOfPinnedArrayElement(outputBuffer, 0), 0, (int)hbOutputLength);

            uint ioctl = Convert.ToUInt32(tbIOCTL.Text, 16);
            DeviceIoControl(sfh, ioctl, inputBuffer, inputSize, outputBuffer, outputSize, ref returnedBytes, IntPtr.Zero);
            int errorCode = Marshal.GetLastWin32Error();

            DynamicByteProvider requestData = new DynamicByteProvider(inputBuffer);
            hbInput.ByteProvider = requestData;

            DynamicByteProvider responseData = new DynamicByteProvider(outputBuffer);
            hbOutput.ByteProvider = responseData;

            Request newTx = new Request();
            newTx.RequestName = String.Format(
                "0x{0:X} ({1:X4}-{2:D5})",
                ioctl,
                CRC16.ComputeChecksum(inputBuffer),
                (int)(DateTime.Now.Ticks % 1e11 / 1e6));
            newTx.DevicePath = tbDevicePath.Text;
            newTx.IOCTL = ioctl;
            newTx.PreCallInput = inputBuffer;
            newTx.PostCallOutput = outputBuffer;
            newTx.ReturnValue = errorCode;
            newTx.BytesReturned = returnedBytes;

            if (tlvRequestHistory.SelectedObject == null)
            {
                newTx.Parent = null;
                requests.Add(newTx);
            }
            else
            {
                newTx.Parent = (Request)tlvRequestHistory.SelectedObject;

                if ((newTx.PreCallInput.SequenceEqual(newTx.Parent.PreCallInput)) && (newTx.Parent.Parent != null))
                    newTx.Parent.Children.Add(newTx);
                else
                    newTx.Children.Add(newTx);
            }

            tlvRequestHistory.HideSelection = false;
            tlvRequestHistory.SetObjects(requests);
            tlvRequestHistory.Expand(newTx.Parent);
            tlvRequestHistory.Sort(tlvRequestHistory.GetColumn(3), SortOrder.Descending);
            return;
        }

        /// <summary>
        /// Mark the selected request as a favourite.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStarRequest_Click(object sender, EventArgs e)
        {
            if (tlvRequestHistory.SelectedIndex == -1) return;
            ((Request)tlvRequestHistory.SelectedObject).IsFavourite ^= true;
            tlvRequestHistory.SetObjects(requests);
        }

        private struct OmniSmiPayload
        {
            public IntPtr memory;
            public UInt32 size;
        };

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            // ToDo
        }

        /// <summary>
        /// Filters results in the Request History view (TODO).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFilters_TextChanged(object sender, EventArgs e)
        {
            tlvRequestHistory.ModelFilter = null;
            tlvRequestHistory.ModelFilter = new ModelFilter(delegate (Object tx)
            {
                return ((Request)tx).RequestName.Contains(tbFilters.Text);
            });
        }

        /// <summary>
        /// Shows the About window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AboutForm"] as AboutForm == null)
            {
                AboutForm aboutForm = new AboutForm();
                aboutForm.Show();
            }
            else
            {
                AboutForm aboutForm = Application.OpenForms["AboutForm"] as AboutForm;
                aboutForm.Focus();
            }
        }
    }
}
