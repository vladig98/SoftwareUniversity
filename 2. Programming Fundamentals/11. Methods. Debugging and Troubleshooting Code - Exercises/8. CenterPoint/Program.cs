using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            FindTheCloserToTheCenterPoint(x1, y1, x2, y2);
        }

        private static void FindTheCloserToTheCenterPoint(double x1, double y1, double x2, double y2)
        {
            double d1 = (double)Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double d2 = (double)Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (d1 <= d2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
