using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

        public double Length { get { return length; } private set { length = value; } }
        public double Height { get { return height; } private set { height = value; } }
        public double Width { get { return width; } private set { width = value; } }

        public Box(double length, double width, double height)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }

        public double CalculateVolume()
        {
            return width * height * length;
        }
    }
}
