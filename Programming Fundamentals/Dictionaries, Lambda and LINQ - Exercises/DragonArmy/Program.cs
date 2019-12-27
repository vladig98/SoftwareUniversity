using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();

                tokens[2] = tokens[2] == "null" ? "45" : tokens[2];
                tokens[3] = tokens[3] == "null" ? "250" : tokens[3];
                tokens[4] = tokens[4] == "null" ? "10" : tokens[4];

                if (dragons.ContainsKey(tokens[0]))
                {
                    if (dragons[tokens[0]].ContainsKey(tokens[1]))
                    {
                        dragons[tokens[0]][tokens[1]] = new List<int>() { int.Parse(tokens[2]), int.Parse(tokens[3]), int.Parse(tokens[4]) };
                    }
                    else
                    {
                        dragons[tokens[0]].Add(tokens[1], new List<int>() { int.Parse(tokens[2]), int.Parse(tokens[3]), int.Parse(tokens[4]) });
                    }
                }
                else
                {
                    dragons.Add(tokens[0], new Dictionary<string, List<int>>() { { tokens[1], new List<int>() { int.Parse(tokens[2]), int.Parse(tokens[3]), int.Parse(tokens[4]) } } });
                }
            }

            foreach (var item in dragons)
            {
                Console.WriteLine($"{item.Key}::({string.Format("{0:F2}", item.Value.Select(x => x.Value[0]).Average())}/{string.Format("{0:F2}", item.Value.Select(x => x.Value[1]).Average())}/{string.Format("{0:F2}", item.Value.Select(x => x.Value[2]).Average())})");
                foreach (var item2 in item.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{item2.Key} -> damage: {item2.Value[0]}, health: {item2.Value[1]}, armor: {item2.Value[2]}");
                }
            }
        }
    }
}
