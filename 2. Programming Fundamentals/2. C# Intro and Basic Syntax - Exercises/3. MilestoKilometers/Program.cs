using System;

namespace MilestoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", miles * 1.60934);
        }
    }
}
