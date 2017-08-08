using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_8_Homework_7
{
    public partial class ShapeOptionsDialog : Form
    {
        private BindingList<Shape> shapeList;
        private BindingSource shapeSource;

        protected override void OnPaint(PaintEventArgs e)
        {
            MessageBox.Show("OnPaint called");
            e.Graphics.DrawString("abcdefghijklmnopqrstuvxwyz",
                new Font("Arial", 12), new SolidBrush(Color.Red), 0, 0);
        }

        BindingManagerBase BindingManager
        {
            get { return BindingContext[shapeList]; }
        }

        Shape Current
        {
            get { return (Shape)BindingManager.Current; }
        }

        public ShapeOptionsDialog()
        {
            InitializeComponent();

            shapeList = new BindingList<Shape>();
            shapeSource = new BindingSource();
            shapeSource.DataSource = shapeList;
            bindingNavigator.BindingSource = shapeSource;

            xTextBox.DataBindings.Add("Text", shapeList, "X");
            yTextBox.DataBindings.Add("Text", shapeList, "Y");
            widthTextBox.DataBindings.Add("Text", shapeList, "Width");
            heightTextBox.DataBindings.Add("Text", shapeList, "Height");
            penColorTextBox.DataBindings.Add("Text", shapeList, "PenColor.Name");
            brushColorTextBox.DataBindings.Add("Text", shapeList, "BrushColor.Name");
            penColorPanel.DataBindings.Add("BackColor", shapeList, "PenColor");
            brushColorPanel.DataBindings.Add("BackColor", shapeList, "BrushColor");

            penStyleComboBox.DataSource = Enum.GetValues(typeof(Pens));
            brushStyleComboBox.DataSource = Enum.GetValues(typeof(Brushes));

            shapeList.Add(new Shape(7, 6, 4, 8, Color.Yellow, Pens.Solid, Color.Green, Brushes.LinearGradient, Shapes.Rectangle));
            shapeList.Add(new Shape(4, 1, 3, 5, Color.Red, Pens.Compound, Color.Blue, Brushes.Hatched, Shapes.Ellipse));

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            BindingManager.Position = 0;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            BindingManager.Position--;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            BindingManager.Position++;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            BindingManager.Position = BindingManager.Count - 1;
        }
    }
}
