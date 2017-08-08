namespace Group8_Homework_3A
{
    partial class NeoMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeoMainForm));
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preferencesModalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModelessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesModelessToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLoginDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContextMenu.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesModalToolStripMenuItem,
            this.preferencesModelessToolStripMenuItem});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(189, 48);
            // 
            // preferencesModalToolStripMenuItem
            // 
            this.preferencesModalToolStripMenuItem.Name = "preferencesModalToolStripMenuItem";
            this.preferencesModalToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.preferencesModalToolStripMenuItem.Text = "Preferences Modal";
            this.preferencesModalToolStripMenuItem.Click += new System.EventHandler(this.preferencesModalToolStripMenuItem_Click);
            // 
            // preferencesModelessToolStripMenuItem
            // 
            this.preferencesModelessToolStripMenuItem.Name = "preferencesModelessToolStripMenuItem";
            this.preferencesModelessToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.preferencesModelessToolStripMenuItem.Text = "Preferences Modeless";
            this.preferencesModelessToolStripMenuItem.Click += new System.EventHandler(this.preferencesModelessToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 310);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(399, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel.Text = "ChildStatusLabel";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.windowToolStripMenuItem;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(399, 24);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipticFormToolStripMenuItem,
            this.rectangularFormToolStripMenuItem,
            this.customFormToolStripMenuItem,
            this.closeAllChildrenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ellipticFormToolStripMenuItem
            // 
            this.ellipticFormToolStripMenuItem.Name = "ellipticFormToolStripMenuItem";
            this.ellipticFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipticFormToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.ellipticFormToolStripMenuItem.Text = "Elliptic Form";
            this.ellipticFormToolStripMenuItem.Click += new System.EventHandler(this.ellipticFormToolStripMenuItem_Click);
            // 
            // rectangularFormToolStripMenuItem
            // 
            this.rectangularFormToolStripMenuItem.Name = "rectangularFormToolStripMenuItem";
            this.rectangularFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangularFormToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.rectangularFormToolStripMenuItem.Text = "Rectangular Form";
            this.rectangularFormToolStripMenuItem.Click += new System.EventHandler(this.rectangularFormToolStripMenuItem_Click);
            // 
            // customFormToolStripMenuItem
            // 
            this.customFormToolStripMenuItem.Name = "customFormToolStripMenuItem";
            this.customFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.customFormToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.customFormToolStripMenuItem.Text = "Custom Form";
            this.customFormToolStripMenuItem.Click += new System.EventHandler(this.customFormToolStripMenuItem_Click);
            // 
            // closeAllChildrenToolStripMenuItem
            // 
            this.closeAllChildrenToolStripMenuItem.Name = "closeAllChildrenToolStripMenuItem";
            this.closeAllChildrenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.End)));
            this.closeAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.closeAllChildrenToolStripMenuItem.Text = "Close All Children";
            this.closeAllChildrenToolStripMenuItem.Visible = false;
            this.closeAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesModalToolStripMenuItem1,
            this.preferencesModelessToolStripMenuItem1,
            this.resetLoginDialogToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // preferencesModalToolStripMenuItem1
            // 
            this.preferencesModalToolStripMenuItem1.Name = "preferencesModalToolStripMenuItem1";
            this.preferencesModalToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.preferencesModalToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.preferencesModalToolStripMenuItem1.Text = "Preferences Modal";
            this.preferencesModalToolStripMenuItem1.Click += new System.EventHandler(this.preferencesModalToolStripMenuItem_Click);
            // 
            // preferencesModelessToolStripMenuItem1
            // 
            this.preferencesModelessToolStripMenuItem1.Name = "preferencesModelessToolStripMenuItem1";
            this.preferencesModelessToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.preferencesModelessToolStripMenuItem1.Size = new System.Drawing.Size(252, 22);
            this.preferencesModelessToolStripMenuItem1.Text = "Preferences Modeless";
            this.preferencesModelessToolStripMenuItem1.Click += new System.EventHandler(this.preferencesModelessToolStripMenuItem_Click);
            // 
            // resetLoginDialogToolStripMenuItem
            // 
            this.resetLoginDialogToolStripMenuItem.Name = "resetLoginDialogToolStripMenuItem";
            this.resetLoginDialogToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.resetLoginDialogToolStripMenuItem.Text = "Reset Login Dialog";
            this.resetLoginDialogToolStripMenuItem.Click += new System.EventHandler(this.resetLoginDialogToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // NeoMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 332);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "NeoMainForm";
            this.Text = "NeoMainForm";
            this.Activated += new System.EventHandler(this.childInfoToolStripStatusLabel);
            this.Deactivate += new System.EventHandler(this.childInfoToolStripStatusLabel);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Enter += new System.EventHandler(this.childInfoToolStripStatusLabel);
            this.Leave += new System.EventHandler(this.childInfoToolStripStatusLabel);
            this.mainContextMenu.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesModalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesModelessToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipticFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesModalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesModelessToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLoginDialogToolStripMenuItem;
    }
}