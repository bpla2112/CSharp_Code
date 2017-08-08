using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Group8_Homework_3A
{
    public partial class CustomChild : FoundationControlLibrary.BaseForm
    {
        public CustomChild()
        {
            InitializeComponent();
        }

        public CustomChild(double ratio, int width)
        {
            InitializeComponent();
            this.Width = width;
            this.Height = (int)ratio * width;
        }

        void SetCustomRegion()
        {
            Rectangle rect = this.ClientRectangle;
            Rectangle topLeftEllipse = new Rectangle(rect.X, rect.Y, rect.Width / 2, rect.Height / 2);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);
                path.AddEllipse(topLeftEllipse);
                this.Region = new Region(path);
            }
        }

        private void CustomChild_Load(object sender, EventArgs e)
        {
            SetCustomRegion();
        }
    }
}
