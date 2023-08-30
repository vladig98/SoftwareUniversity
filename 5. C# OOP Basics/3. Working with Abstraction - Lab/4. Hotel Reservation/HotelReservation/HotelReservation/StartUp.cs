using System;

namespace HotelReservation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');

            double pricePerDay = double.Parse(inputTokens[0]);
            int numberOfDays = int.Parse(inputTokens[1]);
            string season = inputTokens[2];
            string discount = null;

            if (inputTokens.Length > 3)
            {
                discount = inputTokens[3];
            }

            PriceCalculator priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);

            Console.WriteLine(priceCalculator.Calculate().ToString("F2"));
        }
    }
}
