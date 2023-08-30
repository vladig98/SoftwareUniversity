using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (command != "report")
            {
                string[] tokens = command.Split("|").ToArray();
                if (countries.ContainsKey(tokens[1]))
                {
                    if (countries[tokens[1]].ContainsKey(tokens[0]))
                    {
                        countries[tokens[1]][tokens[0]] += long.Parse(tokens[2]);
                    }
                    else
                    {
                        countries[tokens[1]].Add(tokens[0], long.Parse(tokens[2]));
                    }
                }
                else
                {
                    countries.Add(tokens[1], new Dictionary<string, long>() { { tokens[0], long.Parse(tokens[2]) } });
                }
                command = Console.ReadLine();
            }

            countries = countries.OrderByDescending(x => x.Value.Sum(y => y.Value)).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in countries)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(x => x.Value)})");
                foreach (var item2 in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{item2.Key}: {item2.Value}");
                }
            }
        }
    }
}
