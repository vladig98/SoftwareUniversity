using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            List<Town> towns = new List<Town>();

            for (int i = 0; i < until; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                if (towns.Any(x => x.Name == input[0]))
                {
                    Town town = towns.FirstOrDefault(x => x.Name == input[0]);
                    town.Total += double.Parse(input[2]) * double.Parse(input[3]);
                }
                else
                {
                    towns.Add(new Town(input[0], input[1], double.Parse(input[2]), double.Parse(input[3])));
                }
            }

            towns = towns.OrderBy(x => x.Name).ToList<Town>();

            foreach (var item in towns)
            {
                Console.WriteLine($"{item.Name} -> {item.Total.ToString("F2")}");
            }
        }

        public class Town
        {
            public string Name { get; set; }

            public double Total { get; set; }

            public Town(string Name, string product, double price, double quantity)
            {
                this.Name = Name;
                this.Total = price * quantity;
            }
        }
    }
}
