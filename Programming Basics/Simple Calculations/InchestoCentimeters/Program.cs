using System;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Centimeters = " + inches * 2.54);
        }
    }
}
