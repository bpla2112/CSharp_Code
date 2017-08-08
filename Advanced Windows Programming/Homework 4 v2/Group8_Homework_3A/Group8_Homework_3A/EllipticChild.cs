using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using FoundationControlLibrary;

namespace Group8_Homework_3A
{
    public partial class Elliptic_Child : BaseForm
    {
        public Elliptic_Child(double ratio, int width)
        {
            InitializeComponent();
            this.Height = (int)ratio * width;
            this.Width = width;
        }

        void SetEllipseRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }
        }

        void Elliptic_Load(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }
    }
}
