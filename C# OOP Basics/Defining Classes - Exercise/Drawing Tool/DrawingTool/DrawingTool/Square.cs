using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingTool
{
    public class Square : Shape
    {
        public Square(int side)
        {
            Width = side;
            Height = side;
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
