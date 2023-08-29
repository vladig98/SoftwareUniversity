using System;

namespace PointintheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;
            int x3 = h;
            int y3 = h;
            int x4 = 2 * h;
            int y4 = 4 * h;

            if (x > x1 && x < x2 && y > y1 && y < y2)
            {
                Console.WriteLine("inside");
            }
            else if (x > x3 && x < x4 && y > y3 && y < y4)
            {
                Console.WriteLine("inside");
            }
            else if (y == h && x > h && x < h * 2)
            {
                Console.WriteLine("inside");
            }
            else if (x == x1 && y >= y1 && y <= y2)
            {
                Console.WriteLine("border");
            }
            else if (x == x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("border");
            }
            else if (x == x3 && y >= y3 && y <= y4)
            {
                Console.WriteLine("border");
            }
            else if (x == x4 && y >= y3 && y <= y4)
            {
                Console.WriteLine("border");
            }
            else if (y == y1 && x >= x1 && x <= x2)
            {
                Console.WriteLine("border");
            }
            else if (y == y2 && x >= x1 && x <= x2)
            {
                Console.WriteLine("border");
            }
            else if (y == y3 && x >= x3 && x <= x4)
            {
                Console.WriteLine("border");
            }
            else if (y == y4 && x >= x3 && x <= x4)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
