using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", ConvertToCelcius(fahrenheit));
        }

        static double ConvertToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9.0;
        }
    }
}
