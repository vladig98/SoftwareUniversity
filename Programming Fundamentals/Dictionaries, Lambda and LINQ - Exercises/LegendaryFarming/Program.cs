using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0}
            };

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(" ").Select(x => x.ToLower()).ToArray();
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    if (items.ContainsKey(tokens[i + 1]))
                    {
                        items[tokens[i + 1]] += int.Parse(tokens[i]);
                    }
                    else
                    {
                        items.Add(tokens[i + 1], int.Parse(tokens[i]));
                    }

                    if (items.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").Any(x => x.Value >= 250))
                    {
                        if (items.Where(x => x.Key == "shards").FirstOrDefault().Value >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                        }
                        else if (items.Where(x => x.Key == "fragments").FirstOrDefault().Value >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                        }
                        else if (items.Where(x => x.Key == "motes").FirstOrDefault().Value >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                        }

                        var temp = items.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes").OrderByDescending(x => x.Value % 250).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

                        foreach (var item in temp)
                        {
                            Console.WriteLine($"{item.Key}: {item.Value % 250}");
                        }

                        var temp2 = items.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes").OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

                        foreach (var item in temp2)
                        {
                            Console.WriteLine($"{item.Key}: {item.Value}");
                        }

                        return;
                    }
                }
            }
        }
    }
}
