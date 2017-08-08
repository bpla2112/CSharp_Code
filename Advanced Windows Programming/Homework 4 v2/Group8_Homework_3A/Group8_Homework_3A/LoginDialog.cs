using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_Homework_3A
{
    public partial class LoginDialog : Form
    {
        private bool skipDialog = Properties.Settings.Default.SkipScreen;

        public LoginDialog()
        {
            InitializeComponent();
        }

        private void skipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (skipDialog == false)
            {
                skipDialog = true;
                Properties.Settings.Default.SkipScreen = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                skipDialog = false;
                Properties.Settings.Default.SkipScreen = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
