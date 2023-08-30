using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClothes = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens.Length == 0)
                {
                    continue;
                }
                string color = inputTokens[0];
                List<string> items = new List<string>();

                if (inputTokens.Length > 1)
                {
                    items = inputTokens[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                if (wardrobe.ContainsKey(color))
                {
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (wardrobe[color].ContainsKey(items[j]))
                        {
                            wardrobe[color][items[j]]++;
                        }
                        else
                        {
                            wardrobe[color].Add(items[j], 1);
                        }
                    }
                }
                else
                {
                    Dictionary<string, int> itemsFromColor = new Dictionary<string, int>();

                    for (int j = 0; j < items.Count; j++)
                    {
                        if (itemsFromColor.ContainsKey(items[j]))
                        {
                            itemsFromColor[items[j]]++;
                        }
                        else
                        {
                            itemsFromColor.Add(items[j], 1);
                        }
                    }

                    wardrobe.Add(color, itemsFromColor);
                }
            }

            string[] findTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string findColor = "";
            string findItem = "";

            if (findTokens.Length != 0)
            {
                findColor = findTokens[0];
                findItem = findTokens[1];
            }

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (item.Key == findItem && color.Key == findColor)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
