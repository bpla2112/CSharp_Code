namespace Group8_Homework2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.sizeButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.namesListView = new System.Windows.Forms.ListView();
            this.names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.HWIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.controlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.controlGroupBox.Controls.Add(this.nameTextBox);
            this.controlGroupBox.Controls.Add(this.resetButton);
            this.controlGroupBox.Controls.Add(this.locationButton);
            this.controlGroupBox.Controls.Add(this.sizeButton);
            this.controlGroupBox.Controls.Add(this.nameButton);
            this.controlGroupBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.controlGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(309, 116);
            this.controlGroupBox.TabIndex = 0;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Controls";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(111, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(114, 20);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(207, 75);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(85, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset Settings";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.Location = new System.Drawing.Point(111, 75);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(85, 23);
            this.locationButton.TabIndex = 2;
            this.locationButton.Text = "Save Location";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(25, 75);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 23);
            this.sizeButton.TabIndex = 1;
            this.sizeButton.Text = "Save Size";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(25, 35);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 0;
            this.nameButton.Text = "Add Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.addNameButton_Click);
            // 
            // namesListView
            // 
            this.namesListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.namesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.names});
            this.namesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namesListView.Location = new System.Drawing.Point(0, 116);
            this.namesListView.Name = "namesListView";
            this.namesListView.Size = new System.Drawing.Size(309, 245);
            this.namesListView.TabIndex = 1;
            this.namesListView.UseCompatibleStateImageBehavior = false;
            this.namesListView.View = System.Windows.Forms.View.Details;
            // 
            // names
            // 
            this.names.Text = "Names";
            this.names.Width = 100;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // HWIcon
            // 
            this.HWIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("HWIcon.Icon")));
            this.HWIcon.Text = "Click Me Please";
            this.HWIcon.Visible = true;
            this.HWIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AcceptButton = this.nameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(309, 361);
            this.Controls.Add(this.namesListView);
            this.Controls.Add(this.controlGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(324, 249);
            this.Name = "MainForm";
            this.Text = "Add-Nameifier 9000 v1";
            this.Deactivate += new System.EventHandler(this.lostFocus);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.controlGroupBox.ResumeLayout(false);
            this.controlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.ListView namesListView;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ColumnHeader names;
        private System.Windows.Forms.NotifyIcon HWIcon;
    }
}

