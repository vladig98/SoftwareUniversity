using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmails = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> domains = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfEmails; i++)
            {
                string email = Console.ReadLine();

                if (Regex.IsMatch(email, @"\b[A-Za-z]{5,}@[a-z]{3,}(\.com|\.bg|\.org)\b"))
                {
                    string[] partsOfEmail = email.Split("@").ToArray();

                    if (domains.Keys.Contains(partsOfEmail[1]))
                    {
                        if (domains[partsOfEmail[1]].Contains(partsOfEmail[0]))
                        {
                            continue;
                        }
                        domains[partsOfEmail[1]].Add(partsOfEmail[0]);
                    }
                    else
                    {
                        domains.Add(partsOfEmail[1], new List<string> { partsOfEmail[0] });
                    }
                }
            }

            domains = domains.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var domain in domains)
            {
                Console.WriteLine(domain.Key + ":");
                foreach (var item in domain.Value)
                {
                    Console.WriteLine("### " + item);
                }
            }
        }
    }
}
