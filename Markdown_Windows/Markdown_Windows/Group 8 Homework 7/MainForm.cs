using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace Group_8_Homework_7
{
    public partial class MainForm : FoundationControlLibrary.BaseForm
    {
        private string FileName { get; set; }
        private Document document;
        private Point downPoint = Point.Empty;
        Shape shape;

        public MainForm()
        {
            InitializeComponent();
            ToolStripManager.Merge(this.baseMenuStrip, this.mainMenuStrip);
            this.baseMenuStrip.Visible = false;
            shape = new Shape(2, 2, 3, 5, Color.AliceBlue, Pens.Solid, Color.AntiqueWhite, Brushes.Hatched, Shapes.Rectangle);
        }

        protected override void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OathDialog oath = new OathDialog();
            oath.DesktopLocation = new Point( this.Right, this.Top);
            oath.Show(this);
        }

        protected override void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.DesktopLocation = new Point(this.Left, this.Bottom);
            about.Show(this);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.ShapeType = Shapes.Ellipse;
        }

        private void uncheckItems(object sender)
        {
            var menuItem = sender as ToolStripMenuItem;
            foreach (ToolStripMenuItem item in menuItem.Owner.Items)
            {
                item.Checked = false;
            }
            menuItem.Checked = true;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.ShapeType = Shapes.Rectangle;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.ShapeType = Shapes.Custom;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.PenType = Pens.Solid;
        }

        private void customDashedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.PenType = Pens.Dashed;
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.PenType = Pens.Compound;
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            Brush brush = System.Drawing.Brushes.Black; //default color
            shape.BrushType = Brushes.Solid;
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.BrushType = Brushes.Hatched;
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckItems(sender);
            shape.BrushType = Brushes.LinearGradient;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = "shape";
                dlg.Filter = "Shape files (*.shape)|*.shape|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Serialize(FileName = dlg.FileName);
                    this.FileName = dlg.FileName;
                    this.Text = this.FileName;                    
                }
            }
        }

        public void Serialize(string fileName)
        {
            using (Stream stream =
                new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, shape);
            }
        }

        public void Deserialize(string fileName)
        {
            using (Stream stream =
                new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                shape = (Shape)formatter.Deserialize(stream);
            }
        }

        private void saveShapes()
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Shape Files (*.shape)|*.shape|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Deserialize(dlg.FileName);
                }
            }
        }

        private void shapeOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ShapeOptionsDialog shapeOptionsDialog = new ShapeOptionsDialog()) {

                shapeOptionsDialog.ShowDialog();

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
            shape.X = downPoint.X;
            shape.Y = downPoint.Y;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;

            shape.Height = e.Y - downPoint.Y;
            shape.Width = e.X - downPoint.X;
            this.Invalidate();
 
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (shape.ShapeType == Shapes.Rectangle)
            {
                using (SolidBrush brush = new SolidBrush(shape.BrushColor))
                {
                    using (Pen pen = new Pen(shape.PenColor, 10))
                    {
                        g.FillRectangle(brush, shape.X, shape.Y, shape.Width, shape.Height);
                        g.DrawRectangle(pen, shape.X, shape.Y, shape.Width, shape.Height);
                    }

                }
            }

            if (shape.ShapeType == Shapes.Ellipse)
            {
                using (SolidBrush brush = new SolidBrush(shape.BrushColor))
                {
                    using (Pen pen = new Pen(shape.PenColor, 10))
                    {
                        g.FillEllipse(brush, shape.X, shape.Y, shape.Width, shape.Height);
                        g.DrawEllipse(pen, shape.X, shape.Y, shape.Width, shape.Height);
                    }

                }
            }

        }

        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = shape.PenColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    shape.PenColor = colorDialog.Color;
                }
            }
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = shape.BrushColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    shape.BrushColor = colorDialog.Color;
                }
            }
        }
    }
}
