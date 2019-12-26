using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", sideA * sideB);
        }
    }
}
