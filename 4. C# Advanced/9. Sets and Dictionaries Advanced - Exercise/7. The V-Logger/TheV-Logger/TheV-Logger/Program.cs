using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> vloggers = new Dictionary<string, HashSet<string>>();

            const string end = "Statistics";

            string input = Console.ReadLine();

            while (input != end)
            {
                string[] inputTokens = input.Split(" followed ", StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length != 2)
                {
                    inputTokens = input.Split(" joined The V-Logger", StringSplitOptions.RemoveEmptyEntries);

                    if (!vloggers.ContainsKey(inputTokens[0]))
                    {
                        vloggers.Add(inputTokens[0], new HashSet<string>());
                    }
                }
                else
                {
                    if (vloggers.ContainsKey(inputTokens[1]) && vloggers.ContainsKey(inputTokens[0]) && inputTokens[0] != inputTokens[1])
                    {
                        vloggers[inputTokens[1]].Add(inputTokens[0]);
                    }
                }

                input = Console.ReadLine();
            }

            vloggers = vloggers.OrderByDescending(x => x.Value.Count).ThenBy(x => vloggers.Where(y => y.Value.Contains(x.Key)).Select(y => y.Key).Count()).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            for (int i = 0; i < vloggers.Count; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{(i+1)}. {vloggers.ElementAt(i).Key} : {vloggers.ElementAt(i).Value.Count} followers, {vloggers.Where(x => x.Value.Contains(vloggers.ElementAt(i).Key)).Count()} following");
                    if (vloggers.ElementAt(i).Value.Count > 0)
                    {
                        foreach (var follower in vloggers.ElementAt(i).Value.OrderBy(x => x))
                        {
                            Console.WriteLine($"*  {follower}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{(i + 1)}. {vloggers.ElementAt(i).Key} : {vloggers.ElementAt(i).Value.Count} followers, {vloggers.Where(x => x.Value.Contains(vloggers.ElementAt(i).Key)).Count()} following");
                }
            }
        }
    }
}
