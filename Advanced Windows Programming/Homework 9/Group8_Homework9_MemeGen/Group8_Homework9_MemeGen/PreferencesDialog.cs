using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_Homework9_MemeGen
{
    public partial class PreferencesDialog : Form, IPreferencesDialog, INotifyPropertyChanged
    {

        private Font leftPanelFont;
        private BindingSource BindingSource;

        public Font LeftPanelFont { get { return leftPanelFont; } set { this.leftPanelFont = value; this.fontSizeNumericUpDown.Value = (decimal) value.Size;  this.fontTextBox.Text = value.Name;  OnChange("LeftPanelFont"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        public PreferencesDialog()
        {
            InitializeComponent();
            this.BindingSource = new BindingSource();
        }

        public PreferencesDialog(BindingSource bindingSource)
        {
            InitializeComponent();
            this.BindingSource = bindingSource;
        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.fontColorPanel.DataBindings.Add("BackColor", this.BindingSource, "LeftPanelFontColor", true, DataSourceUpdateMode.OnPropertyChanged);
            this.leftPanelColor.DataBindings.Add("BackColor", this.BindingSource, "LeftPanelBackColor", true, DataSourceUpdateMode.OnPropertyChanged);
            this.DataBindings.Add("LeftPanelFont", this.BindingSource, "LeftPanelFont", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        protected void OnChange(string propName) { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propName)); }

        private void backColorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = this.leftPanelColor.BackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                    this.leftPanelColor.BackColor = colorDialog.Color;
            }
        }

        private void fontNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = this.LeftPanelFont;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.LeftPanelFont = fontDialog.Font;
                    this.fontSizeNumericUpDown.Value = (decimal)this.LeftPanelFont.Size;
                    this.fontTextBox.Text = this.LeftPanelFont.Name;
                }
            }
        }
        private void fontColorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = this.fontColorPanel.BackColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                    this.fontColorPanel.BackColor = colorDialog.Color;
            }
        }

        private void fontSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.LeftPanelFont = new Font(this.LeftPanelFont.Name, (float) this.fontSizeNumericUpDown.Value, this.LeftPanelFont.Style);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
