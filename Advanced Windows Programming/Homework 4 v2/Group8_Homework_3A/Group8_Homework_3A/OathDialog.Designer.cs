namespace Group8_Homework_3A
{
    partial class OathDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OathDialog));
            this.oathUserControl = new FoundationControlLibrary.OathUserControl();
            this.dialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dialogPanel
            // 
            this.dialogPanel.Controls.Add(this.oathUserControl);
            this.dialogPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dialogPanel.Size = new System.Drawing.Size(595, 161);
            // 
            // oathUserControl
            // 
            this.oathUserControl.BackColor = System.Drawing.Color.Transparent;
            this.oathUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathUserControl.Location = new System.Drawing.Point(0, 0);
            this.oathUserControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.oathUserControl.Name = "oathUserControl";
            this.oathUserControl.Size = new System.Drawing.Size(595, 161);
            this.oathUserControl.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 505);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(425, 25);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OathDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Oath Dialog";
            this.dialogPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FoundationControlLibrary.OathUserControl oathUserControl;
    }
}
