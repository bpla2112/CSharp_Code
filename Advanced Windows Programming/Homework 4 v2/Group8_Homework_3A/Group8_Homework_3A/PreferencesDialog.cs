using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationControlLibrary;
using System.Windows.Forms;

namespace Group8_Homework_3A
{
    class PreferencesDialog : FoundationControlLibrary.BaseDialogForm, IPreferencesDialog
    {
        private System.Windows.Forms.Label Ratio;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox ratioTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolTip toolTip;

        public UserPreferences userPreferences { get; set; }

        public PreferencesDialog() {

            InitializeComponent();

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ratioTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.Ratio = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogPanel
            // 
            this.dialogPanel.Controls.Add(this.cancelButton);
            this.dialogPanel.Controls.Add(this.controlPanel);
            this.dialogPanel.Controls.Add(this.okButton);
            this.dialogPanel.Controls.Add(this.applyButton);
            this.dialogPanel.Size = new System.Drawing.Size(452, 155);
            this.dialogPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dialogPanel_Paint);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(47, 6);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(52, 20);
            this.widthTextBox.TabIndex = 5;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(159, 6);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(52, 20);
            this.heightTextBox.TabIndex = 6;
            // 
            // ratioTextBox
            // 
            this.ratioTextBox.Location = new System.Drawing.Point(273, 6);
            this.ratioTextBox.Name = "ratioTextBox";
            this.ratioTextBox.Size = new System.Drawing.Size(51, 20);
            this.ratioTextBox.TabIndex = 7;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.BackColor = System.Drawing.Color.Transparent;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(4, 6);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 19);
            this.WidthLabel.TabIndex = 8;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(111, 6);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(45, 19);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height";
            // 
            // Ratio
            // 
            this.Ratio.AutoSize = true;
            this.Ratio.BackColor = System.Drawing.Color.Transparent;
            this.Ratio.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratio.Location = new System.Drawing.Point(233, 5);
            this.Ratio.Name = "Ratio";
            this.Ratio.Size = new System.Drawing.Size(37, 19);
            this.Ratio.TabIndex = 10;
            this.Ratio.Text = "Ratio";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.controlPanel.BackColor = System.Drawing.Color.Wheat;
            this.controlPanel.Controls.Add(this.WidthLabel);
            this.controlPanel.Controls.Add(this.Ratio);
            this.controlPanel.Controls.Add(this.widthTextBox);
            this.controlPanel.Controls.Add(this.HeightLabel);
            this.controlPanel.Controls.Add(this.heightTextBox);
            this.controlPanel.Controls.Add(this.ratioTextBox);
            this.controlPanel.Location = new System.Drawing.Point(51, 34);
            this.controlPanel.MaximumSize = new System.Drawing.Size(800, 40);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(347, 40);
            this.controlPanel.TabIndex = 11;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(144, 116);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 33);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(255, 116);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 33);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(368, 116);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(452, 434);
            this.MinimumSize = new System.Drawing.Size(468, 472);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences Dialog";
            this.Activated += new System.EventHandler(this.formIncreaseOpacity);
            this.Deactivate += new System.EventHandler(this.formDecreaseOpacity);
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.dialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void dialogPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void setHelp(Control control, string helpString)
        {

            toolTip.SetToolTip(control, helpString);
            helpProvider.SetHelpString(control, helpString);
                                     
        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {

            if (this.Modal)
            {
                okButton.Location = applyButton.Location;
                applyButton.Hide();
            }

            /* Set ToolTips and Help. */
            string applyButtonHelp = "Apply the specified width, height, and ratio values to new child dialogs.";
            string okButtonHelp = "Save the specified width, height, and ratio values.";
            string widthTextBoxHelp = "Enter a width between " + UserPreferences.minWidth + " and " + UserPreferences.maxWidth + ".";
            string heightTextBoxHelp = "Enter a height between " + UserPreferences.minHeight + " and " + UserPreferences.maxHeight + ".";
            string ratioTextBoxHelp = "Enter a ratio between " + UserPreferences.minRatio + " and " + UserPreferences.maxRatio + ".";
            string cancelButtonHelp = "Cancel saved changes.";

            setHelp(applyButton, applyButtonHelp);
            setHelp(okButton, okButtonHelp);
            setHelp(widthTextBox, widthTextBoxHelp);
            setHelp(heightTextBox, heightTextBoxHelp);
            setHelp(ratioTextBox, ratioTextBoxHelp);
            setHelp(cancelButton, cancelButtonHelp);

            userPreferences = new UserPreferences();

        }

        public event EventHandler OK;
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!areValidPreferences())
                return;

            if (OK != null)
                OK(this, e);

            this.Close();

        }

        public event EventHandler Apply;
        protected virtual void applyButton_Click(object sender, EventArgs e)
        {

            if (!areValidPreferences())
                return;

            errorProvider.SetError(widthTextBox, "");
            errorProvider.SetError(heightTextBox, "");
            errorProvider.SetError(ratioTextBox, "");

            if (Apply != null)
                Apply(this, e);

        }

        private bool areValidPreferences()
        {

            bool valid = true;
            int width, height;
            double ratio;

            Int32.TryParse(widthTextBox.Text, out width);
            Int32.TryParse(heightTextBox.Text, out height);
            Double.TryParse(ratioTextBox.Text, out ratio);

            try
            {
                userPreferences.Width = width;
            }
            catch (ArgumentException ex)
            {
                this.errorProvider.SetError(widthTextBox, ex.Message);
                valid = false;
            }

            try
            {
                userPreferences.Height = height;
            }
            catch (ArgumentException ex)
            {
                this.errorProvider.SetError(heightTextBox, ex.Message);
                valid = false;
            }

            try
            {
                userPreferences.Ratio = ratio;
            }
            catch (ArgumentException ex)
            {
                this.errorProvider.SetError(ratioTextBox, ex.Message);
                valid = false;
            }

            return valid;

        }

        private void shapeOfChild(int width,float height, double ratio)
        {
            width = userPreferences.Width;
            height = userPreferences.Height;
            ratio = userPreferences.Ratio;

            Elliptic_Child ellipse = new Elliptic_Child(height, width);

            RectangularChild rectangle = new RectangularChild(height, width);

        }

        public event EventHandler Canceling;
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (Canceling != null)
                Canceling(this, e);
                   
            this.Close();
        }

        private void formDecreaseOpacity(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void formIncreaseOpacity(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
        }

    }
}
