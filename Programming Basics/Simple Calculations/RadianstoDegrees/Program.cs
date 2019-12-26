using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            Console.WriteLine(rad * 180 / Math.PI);
        }
    }
}
