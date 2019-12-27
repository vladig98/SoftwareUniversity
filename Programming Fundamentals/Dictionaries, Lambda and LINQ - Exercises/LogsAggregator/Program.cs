using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            int until = int.Parse(Console.ReadLine());

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();
                if (users.ContainsKey(tokens[1]))
                {
                    if (users[tokens[1]].ContainsKey(tokens[0]))
                    {
                        users[tokens[1]][tokens[0]] += int.Parse(tokens[2]);
                    }
                    else
                    {
                        users[tokens[1]].Add(tokens[0], int.Parse(tokens[2]));
                    }
                }
                else
                {
                    users.Add(tokens[1], new Dictionary<string, int>() { { tokens[0], int.Parse(tokens[2]) } });
                }
            }

            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum(x => x.Value)} [{string.Join(", ", item.Value.Keys.OrderBy(x => x))}]");
            }
        }
    }
}
