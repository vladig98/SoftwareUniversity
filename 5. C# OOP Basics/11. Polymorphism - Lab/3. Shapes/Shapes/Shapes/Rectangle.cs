using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height { get; set; }
        private double width { get; set; }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                height = value;
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
                width = value;
            }
        }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
