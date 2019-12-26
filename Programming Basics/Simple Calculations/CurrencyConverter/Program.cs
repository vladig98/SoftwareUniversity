using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gbp = 2.53405;
            const double usd = 1.79549;
            const double eur = 1.95583;

            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double converted = 0;

            if (from == "EUR")
            {
                converted = amount * eur;
            }

            if (from == "USD")
            {
                converted = amount * usd;
            }

            if (from == "GBP")
            {
                converted = amount * gbp;
            }

            if (from == "BGN")
            {
                converted = amount;
            }

            if (to == "EUR")
            {
                Console.WriteLine(Math.Round(converted / eur, 2) + " " + to);
            }

            if (to == "USD")
            {
                Console.WriteLine(Math.Round(converted / usd, 2) + " " + to);
            }

            if (to == "GBP")
            {
                Console.WriteLine(Math.Round(converted / gbp, 2) + " " + to);
            }

            if (to == "BGN")
            {
                Console.WriteLine(Math.Round(converted, 2) + " " + to);
            }
        }
    }
}
