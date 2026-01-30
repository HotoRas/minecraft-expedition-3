using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            LabelVersion.Text
                = Resources.VersionA + "." + Resources.VersionB + "." + Resources.VersionC + Resources.VersionSuffix;
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
