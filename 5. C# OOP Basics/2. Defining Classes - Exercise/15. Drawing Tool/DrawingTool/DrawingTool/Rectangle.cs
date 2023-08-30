using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingTool
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            for (int i = 1; i <= Height; i++)
            {
                if (i == 1 || i == Height)
                {
                    Console.WriteLine($"| {string.Join(" ", Enumerable.Repeat("-", Width).ToList())} |");
                }
                else
                {
                    Console.WriteLine($"| {string.Join(" ", Enumerable.Repeat(" ", Width).ToList())} |");
                }
            }
        }
    }
}
