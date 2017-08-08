using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoundationControlLibrary;

namespace Group8_Homework_3A
{
    public partial class NeoMainForm : Form
    {
        UserPreferences savedPreferences; // permanent i.e. when user clicks 'OK'
        UserPreferences userPreferences; // temporary i.e. when user clicks 'Apply'
        PreferencesDialog preferencesDialog;
        Point movement = Point.Empty;

        public NeoMainForm()
        {
            InitializeComponent();
            this.ContextMenuStrip = mainContextMenu;
            //this.mainMenuStrip.MdiWindowListItem.DropDownOpening += MdiWindowListItem_DropDownOpening;
            userPreferences = new UserPreferences();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OathDialog oath = new OathDialog())
            {
               oath.ShowDialog(this);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAboutDialogOpen())
                return;

            AboutDialog about = new AboutDialog();          
            about.Show();
        }

        public void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmExit = new DialogResult();

            confirmExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            e.Cancel = (confirmExit == DialogResult.Cancel);

        }

        private bool isPreferencesDialogOpen() {

            PreferencesDialog _preferencesDialog = Application.OpenForms["PreferencesDialog"] as PreferencesDialog;
            if (_preferencesDialog != null)
            {
                MessageBox.Show("Preferences dialog already open!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool isAboutDialogOpen()
        {

            AboutDialog _preferencesDialog = Application.OpenForms["AboutDialog"] as AboutDialog;
            if (_preferencesDialog != null)
            {
                MessageBox.Show("About dialog already open!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }

        }

        private void preferencesModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPreferencesDialogOpen())
                return;

            preferencesDialog = new PreferencesDialog();
            preferencesDialog.OK += new System.EventHandler(applyAndSaveUserPreferences);
            preferencesDialog.ShowDialog();
        }

        private void applyUserPreferences(object sender, EventArgs e)
        {

            userPreferences = preferencesDialog.userPreferences;

        }

        private void saveUserPreferences(object sender, EventArgs e)
        {


            savedPreferences = userPreferences;

        }

        // modal 'OK'
        private void applyAndSaveUserPreferences(object sender, EventArgs e)
        {

            applyUserPreferences(sender, e);
            saveUserPreferences(sender, e);

        }

        private void preferencesModelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isPreferencesDialogOpen())
                return;

            preferencesDialog = new PreferencesDialog();
            preferencesDialog.Apply += new EventHandler(applyUserPreferences);
            preferencesDialog.OK += new EventHandler(saveUserPreferences);
            preferencesDialog.Show();
        }

        private void ellipticFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Elliptic_Child ellipseKid = new Elliptic_Child(userPreferences.Ratio, userPreferences.Width);
            ellipseKid.MdiParent = this;
            //this.toolStripStatusLabel.Text = "Elliptical Form " + ellipseKid.BackColor;
            ellipseKid.Show();
            this.closeAllChildrenToolStripMenuItem.Visible = true;
        }

        private void rectangularFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangularChild rectangularKid = new RectangularChild(userPreferences.Ratio, userPreferences.Height);
            rectangularKid.MdiParent = this;
            //this.toolStripStatusLabel.Text = "Rectangular Form " + rectangularKid.BackColor;
            rectangularKid.Show();
            this.closeAllChildrenToolStripMenuItem.Visible = true;
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
                this.closeAllChildrenToolStripMenuItem.Visible = false;
            }
        }

        private void customFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomChild customForm = new CustomChild(userPreferences.Ratio, userPreferences.Width);
            customForm.MdiParent = this;
            //this.toolStripStatusLabel.Text = "Custom " + customForm.BackColor;
            customForm.Show();
            this.closeAllChildrenToolStripMenuItem.Visible = true;
        }

        private void resetLoginDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void childInfoToolStripStatusLabel(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel.Text = ActiveMdiChild.Name.ToString() + "  " + ActiveMdiChild.BackColor.ToString();
            }
            catch(NullReferenceException n)
            {
                MessageBox.Show("All Children Closed.");
            }

            

        }

    }
}
