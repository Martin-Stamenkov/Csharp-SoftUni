using System;
using System.Collections.Generic;
using System.Text;
namespace StartUp
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double lenthg, double width, double height)
        {
            Length = lenthg;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }              
        public double Height
        {
            get
            {
                return height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public double CalculateSurfaceArea()
        {
            return (2 * (Length * Width)) + (2 * (Length * Height)) + (2 * (Width * Height));
        }
        public double CalculateLateralSurfaceArea()
        {
            return (2 * (Length * Height)) + (2 * (Width * Height));
        }
        public double CalculateVolumeOfRectangle()
        {
            return Height * Width * Length;
        }
    }
}
