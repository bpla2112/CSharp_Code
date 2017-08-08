using FoundationControlLibrary;
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
    public partial class MainForm : BaseForm
    {
        UserPreferences savedPreferences; // permanent i.e. when user clicks 'OK'
        UserPreferences userPreferences; // temporary i.e. when user clicks 'Apply'
        PreferencesDialog preferencesDialog;
        Point movement = Point.Empty;

        public MainForm()
        {
            InitializeComponent();
            this.ContextMenuStrip = menuContext;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userPreferences = new UserPreferences();
        }
        
        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        public void modalPreferenceForm(string userData)
        {
            InitializeComponent();
        }

        public void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmExit = new DialogResult();

            confirmExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel);
            e.Cancel = (confirmExit == DialogResult.Cancel);

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferncesModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferencesDialog = new PreferencesDialog();
            preferencesDialog.OK += new System.EventHandler(applyAndSaveUserPreferences);
            preferencesDialog.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preferencesModelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferencesDialog = new PreferencesDialog();
            preferencesDialog.Apply += new EventHandler(applyUserPreferences);
            preferencesDialog.OK += new EventHandler(saveUserPreferences);
            preferencesDialog.Show();
        }

        // modeless 'Apply'
        private void applyUserPreferences(object sender, EventArgs e)
        {

            userPreferences = preferencesDialog.userPreferences;

        }

        // modeless 'OK'
        private void saveUserPreferences(object sender, EventArgs e) {


            savedPreferences = userPreferences;

        }

        // modal 'OK'
        private void applyAndSaveUserPreferences(object sender, EventArgs e) {

            applyUserPreferences(sender, e);
            saveUserPreferences(sender, e);

        }

        private void ellipticFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elliptic_Child ellipseKid = new Elliptic_Child();
            ellipseKid.Show();
        }

        private void rectangularFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangularChild rectangularKid = new RectangularChild();
            rectangularKid.Show();
        }

        
    }
    
    
}
