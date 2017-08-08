namespace Group8_Homework_3A
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupNamesUserControl1 = new FoundationControlLibrary.GroupNamesUserControl();
            this.courseSemesterUserControl1 = new FoundationControlLibrary.CourseSemesterUserControl();
            this.courseSemesterUserControl2 = new FoundationControlLibrary.CourseSemesterUserControl();
            this.menuStrip1.SuspendLayout();
            this.menuContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipticFormToolStripMenuItem,
            this.rectangularFormToolStripMenuItem,
            this.preferencesToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // ellipticFormToolStripMenuItem
            // 
            this.ellipticFormToolStripMenuItem.Name = "ellipticFormToolStripMenuItem";
            this.ellipticFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipticFormToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ellipticFormToolStripMenuItem.Text = "Elliptic Form";
            this.ellipticFormToolStripMenuItem.Click += new System.EventHandler(this.ellipticFormToolStripMenuItem_Click);
            // 
            // rectangularFormToolStripMenuItem
            // 
            this.rectangularFormToolStripMenuItem.Name = "rectangularFormToolStripMenuItem";
            this.rectangularFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangularFormToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.rectangularFormToolStripMenuItem.Text = "Rectangular Form";
            this.rectangularFormToolStripMenuItem.Click += new System.EventHandler(this.rectangularFormToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.DropDown = this.menuContext;
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.preferencesToolStripMenuItem1.Text = "Preferences";
            // 
            // menuContext
            // 
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.preferencesModelessToolStripMenuItem});
            this.menuContext.Name = "contextMenuStrip1";
            this.menuContext.OwnerItem = this.preferencesToolStripMenuItem1;
            this.menuContext.Size = new System.Drawing.Size(189, 48);
            this.menuContext.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem1.Text = "Preferences Modal";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.preferncesModalToolStripMenuItem_Click);
            // 
            // preferencesModelessToolStripMenuItem
            // 
            this.preferencesModelessToolStripMenuItem.Name = "preferencesModelessToolStripMenuItem";
            this.preferencesModelessToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.preferencesModelessToolStripMenuItem.Text = "Preferences Modeless";
            this.preferencesModelessToolStripMenuItem.Click += new System.EventHandler(this.preferencesModelessToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // groupNamesUserControl1
            // 
            this.groupNamesUserControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.groupNamesUserControl1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupNamesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupNamesUserControl1.Location = new System.Drawing.Point(0, 24);
            this.groupNamesUserControl1.Name = "groupNamesUserControl1";
            this.groupNamesUserControl1.Size = new System.Drawing.Size(610, 371);
            this.groupNamesUserControl1.TabIndex = 3;
            // 
            // courseSemesterUserControl1
            // 
            this.courseSemesterUserControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.courseSemesterUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseSemesterUserControl1.Location = new System.Drawing.Point(341, 268);
            this.courseSemesterUserControl1.Name = "courseSemesterUserControl1";
            this.courseSemesterUserControl1.Size = new System.Drawing.Size(269, 127);
            this.courseSemesterUserControl1.TabIndex = 4;
            // 
            // courseSemesterUserControl2
            // 
            this.courseSemesterUserControl2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.courseSemesterUserControl2.BackColor = System.Drawing.SystemColors.ControlText;
            this.courseSemesterUserControl2.Location = new System.Drawing.Point(341, 313);
            this.courseSemesterUserControl2.Name = "courseSemesterUserControl2";
            this.courseSemesterUserControl2.Size = new System.Drawing.Size(269, 82);
            this.courseSemesterUserControl2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 395);
            this.Controls.Add(this.courseSemesterUserControl2);
            this.Controls.Add(this.groupNamesUserControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.courseSemesterUserControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ellipticFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularFormToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuContext;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesModelessToolStripMenuItem;
        private FoundationControlLibrary.GroupNamesUserControl groupNamesUserControl1;
        private FoundationControlLibrary.CourseSemesterUserControl courseSemesterUserControl1;
        private FoundationControlLibrary.CourseSemesterUserControl courseSemesterUserControl2;
    }
}

