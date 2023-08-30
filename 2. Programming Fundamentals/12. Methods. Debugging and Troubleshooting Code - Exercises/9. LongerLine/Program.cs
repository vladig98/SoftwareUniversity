using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            FindLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void FindLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);
            double sideC = Math.Abs(x3 - x4);
            double sideD = Math.Abs(y3 - y4);

            double line1 = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            double line2 = Math.Sqrt(Math.Pow(sideC, 2) + Math.Pow(sideD, 2));

            if (line1 >= line2)
            {
                if (FindTheCloserToTheCenterPodouble(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindTheCloserToTheCenterPodouble(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        private static bool FindTheCloserToTheCenterPodouble(double x1, double y1, double x2, double y2)
        {
            double d1 = (double)Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double d2 = (double)Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (d1 <= d2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
