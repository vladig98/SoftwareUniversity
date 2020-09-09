using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, string>> temperatures = new Dictionary<string, Dictionary<double, string>>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)(?=\|)";

            string input = Console.ReadLine();

            while (input != "end")
            {
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    if (temperatures.Keys.Any(x => x == match.Groups[1].Value))
                    {
                        temperatures[match.Groups[1].Value] = new Dictionary<double, string> { { double.Parse(match.Groups[2].Value), match.Groups[3].Value } };
                    }
                    else
                    {
                        Dictionary<double, string> inner = new Dictionary<double, string>();
                        inner.Add(double.Parse(match.Groups[2].Value), match.Groups[3].Value);
                        temperatures.Add(match.Groups[1].Value, inner);
                    }
                }

                input = Console.ReadLine();
            }

            temperatures = temperatures.OrderBy(x => x.Value.Keys.Sum()).ToDictionary(x => x.Key, x => x.Value.OrderBy(y => y.Key).ToDictionary(y => y.Key, y => y.Value));

            foreach (var temperature in temperatures)
            {
                Console.WriteLine($"{temperature.Key} => {temperature.Value.Keys.First():F2} => {temperature.Value.Values.First()}");
            }
        }
    }
}
