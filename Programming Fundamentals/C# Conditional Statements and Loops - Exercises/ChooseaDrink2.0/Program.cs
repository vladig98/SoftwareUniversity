using System;

namespace ChooseaDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            const double waterPrice = 0.7;
            const double coffeePrice = 1;
            const double beerPrice = 1.7;
            const double teaPrice = 1.2;

            string job = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (job)
            {
                case "Athlete":
                    Console.WriteLine($"The {job} has to pay {(quantity * waterPrice).ToString("F2")}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {job} has to pay {(quantity * coffeePrice).ToString("F2")}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {job} has to pay {(quantity * beerPrice).ToString("F2")}.");
                    break;
                default:
                    Console.WriteLine($"The {job} has to pay {(quantity * teaPrice).ToString("F2")}.");
                    break;
            }
        }
    }
}
