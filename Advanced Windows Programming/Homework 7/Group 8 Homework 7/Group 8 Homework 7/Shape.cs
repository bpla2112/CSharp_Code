using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_8_Homework_7
{

    public enum Shapes { Ellipse, Rectangle, Custom };
    public enum Pens { Solid, Dashed, Compound };
    public enum Brushes { Solid, Texture, Hatched, LinearGradient, PathGradient };

    [Serializable]
    public partial class Shape : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _X;
        private int _Y;
        private int _Width;
        private int _Height;
        private Color _PenColor;
        private Color _BrushColor;
        private Pens _PenType;
        private Brushes _BrushType;
        private Shapes _ShapeType;

        public int X
        {
            get { return _X; }
            set
            {
                _X = value;
                OnChange("X");
            }
        }

        public int Y
        {
            get { return _Y; }
            set
            {
                _Y = value;
                OnChange("Y");
            }
        }
        public int Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                OnChange("Width");
            }
        }  
        public int Height
        {
            get { return _Height; }
            set
            {
                _Height = value;
                OnChange("Height");
            }
        }

        public Color PenColor
        {
            get { return _PenColor; }
            set
            {
                _PenColor = value;
                OnChange("PenColor");
            }
        }

        public Pens PenType
        {
            get { return _PenType; }
            set
            {
                _PenType = value;

                OnChange("PenType");
            }
        }

        public Color BrushColor
        {
            get { return _BrushColor; }
            set
            {
                _BrushColor = value;
                OnChange("BrushColor");
            }
        }

        public Brushes BrushType
        {
            get { return _BrushType; }
            set
            {
                _BrushType = value;
                OnChange("BrushType");
            }
        }

        public Shapes ShapeType
        {
            get { return _ShapeType; }
            set
            {
                _ShapeType = value;
                OnChange("ShapeType");
            }
        }

        /* Used for data binding */
        public string PenTypeStr { get; set; }
        public string BrushTypeStr { get; set; }
        public string ShapeTypeStr { get; }

        public Shape(int x, int y, int width, int height, Color penColor, Pens penType, Color brushColor, Brushes brushType, Shapes shapeType)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.PenColor = penColor;
            this.PenType = penType;
            this.BrushColor = brushColor;
            this.BrushType = brushType;
            this.ShapeType = shapeType;
        }

        protected void OnChange(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}