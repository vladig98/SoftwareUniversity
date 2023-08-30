using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double TopLeftCornerX { get; set; }
        public double TopLeftCornerY { get; set; }

        public Rectangle(string id, double width, double height, double topLeftCornerX, double topLeftCornerY)
        {
            Id = id;
            Width = width;
            Height = height;
            TopLeftCornerX = topLeftCornerX;
            TopLeftCornerY = topLeftCornerY;
        }

        public bool Intersect(Rectangle rectangle)
        {
            if ((this.TopLeftCornerX > rectangle.Width + rectangle.TopLeftCornerX) || (this.Width + this.TopLeftCornerX < rectangle.TopLeftCornerX) 
                || (this.TopLeftCornerY > rectangle.Height + rectangle.TopLeftCornerY) || (this.Height + this.TopLeftCornerY < rectangle.TopLeftCornerY))
            {
                return false;
            }

            return true;
        }
    }
}
