using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const string loopUntil = "Revision";

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (input != loopUntil)
            {
                string[] inputTokens = input.Split(",");

                string shopName = inputTokens[0].Trim();
                string productName = inputTokens[1].Trim();
                double productPrice = double.Parse(inputTokens[2]);

                if (shops.ContainsKey(shopName))
                {
                    shops[shopName].Add(productName, productPrice);
                }
                else
                {
                    shops.Add(shopName, new Dictionary<string, double> { { productName, productPrice } });
                }

                input = Console.ReadLine();
            }

            var sortedShops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in sortedShops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
