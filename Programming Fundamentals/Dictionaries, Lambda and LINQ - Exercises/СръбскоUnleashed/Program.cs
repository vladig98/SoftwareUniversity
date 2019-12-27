using System;
using System.Collections.Generic;
using System.Linq;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();

            while (command != "End")
            {
                string[] tokens = command.Split(" @").ToArray();

                if (tokens.Length <= 1)
                {
                    command = Console.ReadLine();
                    continue;
                }

                string singer = tokens[0].Trim();

                string[] subTokens = tokens[1].Split(" ").ToArray();

                string venue = string.Empty;
                int price = 0;

                try
                {
                    if (subTokens.Length > 2)
                    {
                        venue = string.Join(" ", subTokens.Take(subTokens.Length - 2).ToArray());
                        price = int.Parse(subTokens[subTokens.Length - 2]) * int.Parse(subTokens[subTokens.Length - 1]);
                    }
                }
                catch (Exception)
                {
                    command = Console.ReadLine();
                    venue = string.Empty;
                    price = 0;
                    continue;
                }

                if (venue != string.Empty)
                {
                    if (venues.ContainsKey(venue))
                    {
                        if (venues[venue].ContainsKey(singer))
                        {
                            venues[venue][singer] += price;
                        }
                        else
                        {
                            venues[venue].Add(singer, price);
                        }
                    }
                    else
                    {
                        venues.Add(venue, new Dictionary<string, int>() { { singer, price } });
                    }
                }

                command = Console.ReadLine();
                venue = string.Empty;
                price = 0;
            }

            foreach (var item in venues)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}
