using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8_Homework_3A
{
    public class UserPreferences
    {
        private const int defaultWidth = 100;
        private const int defaultHeight = 100;
        private const double defaultRatio = 1.0;

        private const int minWidth = 20;
        private const int minHeight = 20;
        private const double minRatio = 0.5;

        private const int maxWidth = 500;
        private const int maxHeight = 500;
        private const double maxRatio = 3.0;


        private int _width, _height;
        private double _ratio;

        public int Width
        {
            get { return _width; }
            set
            {

                if (value < minWidth)
                    throw new ArgumentException("Width is too small. Please enter an integer more than " + minWidth + ".");
                else if (value > maxWidth)
                    throw new ArgumentException("Width is too large. Please enter an integer less than " + maxWidth + ".");

                _width = value;

            }
        }

        public int Height
        {
            get { return _height; }
            set
            {

                if (value < minHeight)
                    throw new ArgumentException("Height is too small. Please enter an integer more than " + minHeight + ".");
                else if (value > maxHeight)
                    throw new ArgumentException("Height is too large. Please enter an integer less than " + maxHeight + ".");

                _height = value;

            }
        }

        public double Ratio
        {
            get { return _ratio; }
            set
            {

                if (value < minRatio)
                    throw new ArgumentException("Ratio is too small. Please enter a decimal number more than " + minRatio + ".");
                else if (value > maxRatio)
                    throw new ArgumentException("Ratio is too large. Please enter a decimal number less than " + maxRatio + ".");

                _ratio = value;

            }
        }
        public UserPreferences()
        {

            Width = defaultWidth;
            Height = defaultHeight;
            Ratio = defaultRatio;

        }

    }
 
}
