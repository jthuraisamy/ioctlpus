using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ioctlpus
{
    public class Request
    {
        private string requestName;
        private string devicePath;
        private uint ioctl;
        private byte[] preCallInput;
        private byte[] postCallOutput;
        private int returnValue;
        private uint bytesReturned;
        private DateTime timestamp;
        private bool isFavourite;
        private Request parent;
        private List<Request> children;

        public Request()
        {
            this.Timestamp = DateTime.Now;
            this.Children = new List<Request>();
        }

        public string RequestName
        {
            get
            {
                return requestName;
            }

            set
            {
                requestName = value;
            }
        }

        public string DevicePath
        {
            get
            {
                return devicePath;
            }

            set
            {
                devicePath = value;
            }
        }

        public uint IOCTL
        {
            get
            {
                return ioctl;
            }

            set
            {
                ioctl = value;
            }
        }

        public byte[] PreCallInput
        {
            get
            {
                return preCallInput;
            }

            set
            {
                preCallInput = value;
            }
        }

        public byte[] PostCallOutput
        {
            get
            {
                return postCallOutput;
            }

            set
            {
                postCallOutput = value;
            }
        }

        public int ReturnValue
        {
            get
            {
                return returnValue;
            }

            set
            {
                returnValue = value;
            }
        }

        public string ReturnValueString()
        {
            return String.Format("{0} (0x{1:X8}).", new Win32Exception(returnValue).Message, returnValue);
        }

        public uint BytesReturned
        {
            get
            {
                return bytesReturned;
            }

            set
            {
                bytesReturned = value;
            }
        }

        public DateTime Timestamp
        {
            get
            {
                return timestamp;
            }

            set
            {
                timestamp = value;
            }
        }

        public List<Request> Children
        {
            get
            {
                return children;
            }

            set
            {
                children = value;
            }
        }

        public bool IsFavourite
        {
            get
            {
                return isFavourite;
            }

            set
            {
                isFavourite = value;
            }
        }

        public Request Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }
    }
}
