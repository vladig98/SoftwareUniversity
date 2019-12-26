using System;

namespace CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("{0:F12}", area);
        }
    }
}
