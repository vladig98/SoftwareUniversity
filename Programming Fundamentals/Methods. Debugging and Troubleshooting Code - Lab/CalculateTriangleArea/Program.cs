using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", TriangleArea(width, height));
        }

        static double TriangleArea(double width, double height)
        {
            return width * height / 2.0;
        }
    }
}
