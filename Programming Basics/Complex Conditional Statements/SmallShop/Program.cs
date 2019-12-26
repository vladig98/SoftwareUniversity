using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double coffeeSofia = 0.5;
            const double coffeePlovdiv = 0.4;
            const double coffeeVarna = 0.45;
            const double waterSofia = 0.8;
            const double waterPlovdiv = 0.7;
            const double waterVarna = 0.7;
            const double beerSofia = 1.2;
            const double beerPlovdiv = 1.15;
            const double beerVarna = 1.1;
            const double sweetsSofia = 1.45;
            const double sweetsPlovdiv = 1.30;
            const double sweetsVarna = 1.35;
            const double peanutsSofia = 1.60;
            const double peanutsPlovdiv = 1.50;
            const double peanutsVarna = 1.55;

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qunatity = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * coffeeSofia);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * coffeePlovdiv);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * coffeeVarna);
                            break;
                        default:
                            break;
                    }
                    break;
                case "water":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * waterSofia);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * waterPlovdiv);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * waterVarna);
                            break;
                        default:
                            break;
                    }
                    break;
                case "beer":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * beerSofia);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * beerPlovdiv);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * beerVarna);
                            break;
                        default:
                            break;
                    }
                    break;
                case "sweets":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * sweetsSofia);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * sweetsPlovdiv);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * sweetsVarna);
                            break;
                        default:
                            break;
                    }
                    break;
                case "peanuts":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * peanutsSofia);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * peanutsPlovdiv);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * peanutsVarna);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
