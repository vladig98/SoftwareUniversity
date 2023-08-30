using System;
using System.Linq;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(" ").ToArray();
            string[] quantity2 = Console.ReadLine().Split(" ").ToArray();
            string[] prices = Console.ReadLine().Split(" ").ToArray();

            string[] quantity = new string[products.Length];

            for (int i = 0; i < quantity.Length; i++)
            {
                if (i < quantity2.Length)
                {
                    quantity[i] = quantity2[i];
                }
                else
                {
                    quantity[i] = "0";
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "done")
            {
                string[] tokens = cmd.Split(" ").ToArray();
                int index = Array.IndexOf(products, tokens[0]);
                if (long.Parse(quantity[index]) >= long.Parse(tokens[1]))
                {
                    Console.WriteLine($"{tokens[0]} x {tokens[1]} costs {(decimal.Parse(prices[index]) * long.Parse(tokens[1])).ToString("F2")}");
                    quantity[index] = (long.Parse(quantity[index]) - long.Parse(tokens[1])).ToString();
                }
                else
                {
                    Console.WriteLine($"We do not have enough {tokens[0]}");
                }
                cmd = Console.ReadLine();
            }
        }
    }
}
