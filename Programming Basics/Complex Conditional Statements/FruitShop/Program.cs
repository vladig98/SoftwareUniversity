using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double bananaWeekdays = 2.50;
            const double appleWeekdays = 1.2;
            const double orangeWeekdays = 0.85;
            const double grapefruitWeekdays = 1.45;
            const double kiwiWeekdays = 2.7;
            const double pineappleWeekdays = 5.50;
            const double grapesWeekdays = 3.85;
            
            const double bananaWeekend = 2.70;
            const double appleWeekend = 1.25;
            const double orangeWeekend = 0.9;
            const double grapefruitWeekend = 1.6;
            const double kiwiWeekend = 3;
            const double pineappleWeekend = 5.60;
            const double grapesWeekend = 4.20;

            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (fruit)
            {
                case "banana":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * bananaWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * bananaWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "apple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * appleWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * appleWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * orangeWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * orangeWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * grapefruitWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * grapefruitWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * kiwiWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * kiwiWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * pineappleWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * pineappleWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            Console.WriteLine(quantity * grapesWeekdays);
                            break;
                        case "Saturday":
                        case "Sunday":
                            Console.WriteLine(quantity * grapesWeekend);
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
