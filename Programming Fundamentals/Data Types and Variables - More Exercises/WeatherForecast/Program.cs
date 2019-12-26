using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                sbyte temp = sbyte.Parse(number);
                Console.WriteLine("Sunny");
                return;
            }
            catch (Exception)
            {

            }

            try
            {
                int temp = int.Parse(number);
                Console.WriteLine("Cloudy");
                return;
            }
            catch (Exception)
            {

            }

            try
            {
                long temp = long.Parse(number);
                Console.WriteLine("Windy");
                return;
            }
            catch (Exception)
            {

            }

            try
            {
                decimal temp = decimal.Parse(number);
                Console.WriteLine("Rainy");
                return;
            }
            catch (Exception)
            {

            }
        }
    }
}
