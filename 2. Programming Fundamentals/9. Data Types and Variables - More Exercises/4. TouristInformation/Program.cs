using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            const double milesToKm = 1.6;
            const double inchesToCm = 2.54;
            const double feetToCm = 30;
            const double yardsToMeters = 0.91;
            const double galllonsToLiters = 3.8;

            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    Console.WriteLine($"{value} miles = {(value * milesToKm).ToString("F2")} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} inches = {(value * inchesToCm).ToString("F2")} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} feet = {(value * feetToCm).ToString("F2")} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} yards = {(value * yardsToMeters).ToString("F2")} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} gallons = {(value * galllonsToLiters).ToString("F2")} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
