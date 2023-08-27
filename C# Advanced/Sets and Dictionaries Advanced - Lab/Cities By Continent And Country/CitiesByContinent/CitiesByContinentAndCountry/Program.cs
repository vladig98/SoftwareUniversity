using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");

                string continent = inputTokens[0];
                string country = inputTokens[1];
                string city = inputTokens[2];

                if (continentsCountriesCities.ContainsKey(continent))
                {
                    if (continentsCountriesCities[continent].ContainsKey(country))
                    {
                        continentsCountriesCities[continent][country].Add(city);
                    }
                    else
                    {
                        continentsCountriesCities[continent].Add(country, new List<string> { city });
                    }
                }
                else
                {
                    continentsCountriesCities.Add(continent, new Dictionary<string, List<string>> { { country, new List<string> { city } } });
                }
            }

            foreach (var continent in continentsCountriesCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
