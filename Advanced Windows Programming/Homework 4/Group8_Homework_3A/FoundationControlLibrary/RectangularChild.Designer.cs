namespace FoundationControlLibrary
{
    partial class RectangularChild
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
            this.courseSemesterUserControl1 = new FoundationControlLibrary.CourseSemesterUserControl();
            this.SuspendLayout();
            // 
            // courseSemesterUserControl1
            // 
            this.courseSemesterUserControl1.AutoSize = true;
            this.courseSemesterUserControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.courseSemesterUserControl1.BackColor = System.Drawing.Color.Olive;
            this.courseSemesterUserControl1.Location = new System.Drawing.Point(3, 57);
            this.courseSemesterUserControl1.Name = "courseSemesterUserControl1";
            this.courseSemesterUserControl1.Size = new System.Drawing.Size(269, 127);
            this.courseSemesterUserControl1.TabIndex = 0;
            this.courseSemesterUserControl1.MouseCaptureChanged += new System.EventHandler(this.Rectangular_Load);
            // 
            // RectangularChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.courseSemesterUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RectangularChild";
            this.Text = "RectangularChild";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseSemesterUserControl courseSemesterUserControl1;
    }
}