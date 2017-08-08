using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_Homework2
{
    public partial class MainForm : Form
    {
        /* Used to prompt user that name has been added before closing
         * application */
        bool hasNameBeenAdded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ClientSize = Properties.Settings.Default.FormSize;
            this.DesktopLocation = Properties.Settings.Default.Location;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormSize = this.Size;
            Properties.Settings.Default.Save();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            this.Update();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save();
        }

        private void lostFocus(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            menuItemShowForm_Click(sender, e);
        }

        private void menuItemShowForm_Click(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.Activate();
        }

        /* Validate all controls that need validation when 'Add Name' button
         * is clicked. */
        private void addNameButton_Click(object sender, EventArgs e)
        {
            bool isValid = this.ValidateChildren();

            if (!isValid)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                namesListView.Items.Add(nameTextBox.Text);
                nameTextBox.Clear();
                hasNameBeenAdded = true;
            }
           
        }

        /* Validate name textbox. */
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string error = null;
            string name = this.nameTextBox.Text.Trim();

            if (String.IsNullOrWhiteSpace(name))
            {
                error = "Please enter a name";
                e.Cancel = true;
            }
            else if(name.Length > 15)
            {
                error = "Please enter a name no more than 15 characters long";
                e.Cancel = true;
            }

            this.errorProvider.SetError(nameTextBox, error);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult unsavedData = new DialogResult();
            
            if(hasNameBeenAdded == true) // uses name tracking boolean variable for validation
            {
                unsavedData = MessageBox.Show("Names were added. Are you sure you want to quit?", "Exit?", MessageBoxButtons.OKCancel);
                e.Cancel = (unsavedData == DialogResult.Cancel);
            }           
        }
    }
}
