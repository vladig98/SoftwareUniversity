using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            seconds += minutes * 60 + hours * 3600;

            double metersPerSecond = distance / (double)seconds;
            double km = distance / 1000.0;
            double hour = seconds / 3600.0;
            double kmsPerHour = km / hour;
            double miles = distance / 1609.0;
            double milesPerHour = miles / hour;

            Console.WriteLine("{0:F5}", Math.Round(metersPerSecond, 5));
            Console.WriteLine("{0:F5}", Math.Round(kmsPerHour, 5));
            Console.WriteLine("{0:F5}", Math.Round(milesPerHour, 5));
        }
    }
}
