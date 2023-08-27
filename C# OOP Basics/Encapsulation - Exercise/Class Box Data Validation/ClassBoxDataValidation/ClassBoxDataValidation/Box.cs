using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxDataValidation
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

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
                    Console.WriteLine("Length cannot be zero or negative.");
                    throw new Exception();
                }
                else
                {
                    length = value;
                }
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
                    Console.WriteLine("Height cannot be zero or negative.");
                    throw new Exception();
                }
                else
                {
                    height = value;
                }
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
                    Console.WriteLine("Width cannot be zero or negative.");
                    throw new Exception();
                }
                else
                {
                    width = value;
                }
            } 
        }

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
