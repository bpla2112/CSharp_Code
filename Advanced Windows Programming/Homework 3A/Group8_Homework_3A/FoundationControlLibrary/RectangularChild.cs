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

namespace FoundationControlLibrary
{
    public partial class RectangularChild : BaseForm
    {
        public RectangularChild(float height, int width)
        {
            InitializeComponent();
            this.Height = (int)height;
            this.Width = (int)height * width;
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
