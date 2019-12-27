using System;
using System.Linq;

namespace RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            Rectangle rect1 = new Rectangle(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));

            input = Console.ReadLine().Split(" ").ToArray();
            Rectangle rect2 = new Rectangle(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));

            bool isInside = IsInside(rect1, rect2);

            string result = isInside == true ? "Inside" : "Not inside";

            Console.WriteLine(result);
        }

        private static bool IsInside(Rectangle rect1, Rectangle rect2)
        {
            if (rect2.X > rect1.X)
            {
                return false;
            }
            if (rect2.X + rect2.Width < rect1.X + rect1.Width)
            {
                return false;
            }
            if (rect2.Y < rect1.Y)
            {
                return false;
            }
            if (rect2.Y - rect2.Height > rect1.Y - rect1.Height)
            {
                return false;
            }
            return true;
        }

        public class Rectangle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle(int X, int Y, int Width, int Height)
            {
                this.X = X;
                this.Y = Y;
                this.Width = Width;
                this.Height = Height;
            }
        }
    }
}
