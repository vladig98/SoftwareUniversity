using System;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            const double outfall4 = 39.99;
            const double csog = 15.99;
            const double zplinterzell = 19.99;
            const double honored2 = 59.99;
            const double roverwatch = 29.99;
            const double roverwatchoe = 39.99;

            double budget = double.Parse(Console.ReadLine());
            double originalBudget = budget;

            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        if (budget < outfall4)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == outfall4)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > outfall4)
                        {
                            Console.WriteLine("Bought OutFall 4");
                            budget -= outfall4;
                        }
                        break;
                    case "CS: OG":
                        if (budget < csog)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == csog)
                        {
                            Console.WriteLine("Bought CS: OG");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > csog)
                        {
                            Console.WriteLine("Bought CS: OG");
                            budget -= csog;
                        }
                        break;
                    case "Zplinter Zell":
                        if (budget < zplinterzell)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == zplinterzell)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > zplinterzell)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                            budget -= zplinterzell;
                        }
                        break;
                    case "Honored 2":
                        if (budget < honored2)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == honored2)
                        {
                            Console.WriteLine("Bought Honored 2");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > honored2)
                        {
                            Console.WriteLine("Bought Honored 2");
                            budget -= honored2;
                        }
                        break;
                    case "RoverWatch":
                        if (budget < roverwatch)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == roverwatch)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > roverwatch)
                        {
                            Console.WriteLine("Bought RoverWatch");
                            budget -= roverwatch;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (budget < roverwatchoe)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else if (budget == roverwatchoe)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            Console.WriteLine("Out of money!");
                            return;
                        }
                        else if (budget > roverwatchoe)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            budget -= roverwatchoe;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                game = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${(originalBudget - budget).ToString("F2")}. Remaining: ${budget.ToString("F2")}");
        }
    }
}
