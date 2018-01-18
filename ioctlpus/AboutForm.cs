using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ioctlpus
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            InitializeOSC();
        }

        private void InitializeOSC()
        {
            List<OpenSourceComponent> components = new List<OpenSourceComponent>();

            components.Add(new OpenSourceComponent("HexBox", "Bernhard Elbl", "MIT"));
            components.Add(new OpenSourceComponent("HexBox (highlighting)", "Paul Sanford", "MIT"));
            components.Add(new OpenSourceComponent("ObjectListView", "Phillip Piper", "GPLv3"));
            components.Add(new OpenSourceComponent("famfamfam Silk Icons", "Mark James", "CC BY 3.0"));
            components.Add(new OpenSourceComponent("CRC16 Function", "NullFX", "CC BY-NC-SA 3.0"));

            olvComponents.SetObjects(components);
        }
    }

    public class OpenSourceComponent
    {
        private string component;
        private string author;
        private string licence;

        public OpenSourceComponent(string component, string author, string licence)
        {
            this.Component = component;
            this.Author = author;
            this.Licence = licence;
        }

        public string Component
        {
            get
            {
                return component;
            }

            set
            {
                component = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string Licence
        {
            get
            {
                return licence;
            }

            set
            {
                licence = value;
            }
        }
    }
}
