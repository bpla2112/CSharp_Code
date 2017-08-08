namespace Group8_Homework9_MemeGen
{
    partial class PreferencesDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fontColorPanel = new System.Windows.Forms.Panel();
            this.fontColorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.backColorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.fontNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.leftPanelColor = new System.Windows.Forms.Panel();
            this.rightPanelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.leftPanelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumericUpDown)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanelGroupBox
            // 
            this.leftPanelGroupBox.Controls.Add(this.fontSizeLabel);
            this.leftPanelGroupBox.Controls.Add(this.fontSizeNumericUpDown);
            this.leftPanelGroupBox.Controls.Add(this.fontColorPanel);
            this.leftPanelGroupBox.Controls.Add(this.fontColorLinkLabel);
            this.leftPanelGroupBox.Controls.Add(this.fontTextBox);
            this.leftPanelGroupBox.Controls.Add(this.backColorLinkLabel);
            this.leftPanelGroupBox.Controls.Add(this.fontNameLinkLabel);
            this.leftPanelGroupBox.Controls.Add(this.leftPanelColor);
            this.leftPanelGroupBox.Controls.Add(this.rightPanelColor);
            this.leftPanelGroupBox.Controls.Add(this.label1);
            this.leftPanelGroupBox.Controls.Add(this.leftLabel);
            this.leftPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.leftPanelGroupBox.Location = new System.Drawing.Point(0, 0);
            this.leftPanelGroupBox.Name = "leftPanelGroupBox";
            this.leftPanelGroupBox.Size = new System.Drawing.Size(291, 250);
            this.leftPanelGroupBox.TabIndex = 7;
            this.leftPanelGroupBox.TabStop = false;
            this.leftPanelGroupBox.Text = "Left Panel";
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(36, 186);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.fontSizeLabel.TabIndex = 11;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontSizeNumericUpDown
            // 
            this.fontSizeNumericUpDown.Location = new System.Drawing.Point(108, 182);
            this.fontSizeNumericUpDown.Name = "fontSizeNumericUpDown";
            this.fontSizeNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.fontSizeNumericUpDown.TabIndex = 10;
            this.fontSizeNumericUpDown.ValueChanged += new System.EventHandler(this.fontSizeNumericUpDown_ValueChanged);
            // 
            // fontColorPanel
            // 
            this.fontColorPanel.BackColor = System.Drawing.Color.White;
            this.fontColorPanel.Location = new System.Drawing.Point(106, 212);
            this.fontColorPanel.Name = "fontColorPanel";
            this.fontColorPanel.Size = new System.Drawing.Size(173, 20);
            this.fontColorPanel.TabIndex = 8;
            // 
            // fontColorLinkLabel
            // 
            this.fontColorLinkLabel.AutoSize = true;
            this.fontColorLinkLabel.Location = new System.Drawing.Point(36, 216);
            this.fontColorLinkLabel.Name = "fontColorLinkLabel";
            this.fontColorLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.fontColorLinkLabel.TabIndex = 7;
            this.fontColorLinkLabel.TabStop = true;
            this.fontColorLinkLabel.Text = "Font Color";
            this.fontColorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fontColorLinkLabel_LinkClicked);
            // 
            // fontTextBox
            // 
            this.fontTextBox.Enabled = false;
            this.fontTextBox.Location = new System.Drawing.Point(92, 153);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(173, 20);
            this.fontTextBox.TabIndex = 6;
            // 
            // backColorLinkLabel
            // 
            this.backColorLinkLabel.AutoSize = true;
            this.backColorLinkLabel.Location = new System.Drawing.Point(20, 60);
            this.backColorLinkLabel.Name = "backColorLinkLabel";
            this.backColorLinkLabel.Size = new System.Drawing.Size(59, 13);
            this.backColorLinkLabel.TabIndex = 4;
            this.backColorLinkLabel.TabStop = true;
            this.backColorLinkLabel.Text = "Back Color";
            this.backColorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backColorLinkLabel_LinkClicked);
            // 
            // fontNameLinkLabel
            // 
            this.fontNameLinkLabel.AutoSize = true;
            this.fontNameLinkLabel.Location = new System.Drawing.Point(20, 156);
            this.fontNameLinkLabel.Name = "fontNameLinkLabel";
            this.fontNameLinkLabel.Size = new System.Drawing.Size(59, 13);
            this.fontNameLinkLabel.TabIndex = 5;
            this.fontNameLinkLabel.TabStop = true;
            this.fontNameLinkLabel.Text = "Font Name";
            this.fontNameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fontNameLinkLabel_LinkClicked);
            // 
            // leftPanelColor
            // 
            this.leftPanelColor.BackColor = System.Drawing.Color.Black;
            this.leftPanelColor.Location = new System.Drawing.Point(92, 19);
            this.leftPanelColor.Name = "leftPanelColor";
            this.leftPanelColor.Size = new System.Drawing.Size(88, 100);
            this.leftPanelColor.TabIndex = 0;
            // 
            // rightPanelColor
            // 
            this.rightPanelColor.BackColor = System.Drawing.Color.White;
            this.rightPanelColor.Location = new System.Drawing.Point(177, 19);
            this.rightPanelColor.Name = "rightPanelColor";
            this.rightPanelColor.Size = new System.Drawing.Size(88, 100);
            this.rightPanelColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Right";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(122, 122);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(25, 13);
            this.leftLabel.TabIndex = 2;
            this.leftLabel.Text = "Left";
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 250);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(291, 53);
            this.buttonPanel.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(165, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(53, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(291, 303);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.leftPanelGroupBox);
            this.Name = "PreferencesDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.leftPanelGroupBox.ResumeLayout(false);
            this.leftPanelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeNumericUpDown)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        public System.Windows.Forms.GroupBox leftPanelGroupBox;
        public System.Windows.Forms.Panel fontColorPanel;
        public System.Windows.Forms.LinkLabel fontColorLinkLabel;
        public System.Windows.Forms.TextBox fontTextBox;
        public System.Windows.Forms.LinkLabel backColorLinkLabel;
        public System.Windows.Forms.LinkLabel fontNameLinkLabel;
        public System.Windows.Forms.Panel rightPanelColor;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label leftLabel;
        public System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.Button okButton;
        public System.Windows.Forms.Panel leftPanelColor;
        private System.Windows.Forms.NumericUpDown fontSizeNumericUpDown;
        private System.Windows.Forms.Label fontSizeLabel;

    }
}