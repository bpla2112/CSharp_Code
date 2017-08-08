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
    public partial class RectangularChild : BaseForm
    {
        public RectangularChild(double ratio, int height)
        {
            InitializeComponent();
            this.Height = height;
            this.Width = (int)ratio * height;
        }

        void SetRectangularRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);
                this.Region = new Region(path);
            }
        }

        void Rectangular_Load(object sender, EventArgs e)
        {
            SetRectangularRegion();
        }
    }
}
