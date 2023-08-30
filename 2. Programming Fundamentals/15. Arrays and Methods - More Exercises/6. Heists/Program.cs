using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int priceJewel = prices[0];
            int priceGold = prices[1];

            long totalEarnings = 0;
            long totalExpenses = 0;

            string command = Console.ReadLine();

            while (command != "Jail Time")
            {
                string[] tokens = command.Split(" ").ToArray();
                string loot = tokens[0];
                int expenses = int.Parse(tokens[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        totalEarnings += priceJewel;
                    }

                    if (loot[i] == '$')
                    {
                        totalEarnings += priceGold;
                    }
                }

                totalExpenses += expenses;

                command = Console.ReadLine();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }
        }
    }
}
