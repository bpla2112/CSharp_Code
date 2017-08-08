using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8_Homework_3A
{
    public class UserPreferences
    {
        public const int defaultWidth = 100;
        public const int defaultHeight = 100;
        public const double defaultRatio = 1.0;

        public const int minWidth = 30;
        public const int minHeight = 30;
        public const double minRatio = 0.5; 
        public const int maxWidth = 500;
        public const int maxHeight = 500;
        public const double maxRatio = 3.0;

        public int _width, _height;
        public double _ratio;

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
            resetValues();
        }

        public void resetValues()
        {
            Width = defaultWidth;
            Height = defaultHeight;
            Ratio = defaultRatio;
        }

    }
 
}
