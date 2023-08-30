﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
