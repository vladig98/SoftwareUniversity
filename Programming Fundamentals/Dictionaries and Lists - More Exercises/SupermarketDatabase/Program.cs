using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while (command != "stocked")
            {
                string[] tokens = command.Split(" ").ToArray();

                if (products.ContainsKey(tokens[0]))
                {
                    products[tokens[0]][0] = double.Parse(tokens[1]);
                    products[tokens[0]][1] += double.Parse(tokens[2]);
                }
                else
                {
                    products.Add(tokens[0], new List<double>() { double.Parse(tokens[1]), double.Parse(tokens[2]) });
                }

                command = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}: ${(item.Value[0]).ToString("F2")} * {item.Value[1]} = ${(item.Value[0] * item.Value[1]).ToString("F2")}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${(products.Select(x => x.Value[0] * x.Value[1]).Sum()).ToString("F2")}");
        }
    }
}
