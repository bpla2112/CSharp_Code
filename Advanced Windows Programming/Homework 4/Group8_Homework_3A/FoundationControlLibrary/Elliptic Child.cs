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
    public partial class Elliptic_Child : BaseForm
    {
        public Elliptic_Child()
        {
            InitializeComponent();
        }

        //sets the region the ellipse is added to 
        //which is the ClientRectangle
        void SetEllipseRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }
        }

        //loads the ellipse into it's set region
        void Elliptic_Load(object sender, EventArgs e)
        {
            SetEllipseRegion();
        }

    }
}
