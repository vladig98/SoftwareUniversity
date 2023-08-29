using System;

namespace CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());

            Console.WriteLine(celcius * 1.8 + 32);
        }
    }
}
