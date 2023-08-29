using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=<p>).*?(?=<\/p>)";

            string input = Console.ReadLine();

            MatchCollection paragraphs = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            for (int i = 0; i < paragraphs.Count; i++)
            {
                string element = paragraphs.ElementAt(i).Value;

                for (int j = 0; j < element.Length; j++)
                {
                    if (Regex.IsMatch(element[j].ToString(), @"[^a-z0-9]"))
                    {
                        element = element.Remove(j, 1);
                        element = element.Insert(j, " ");
                    }
                    else if (Regex.IsMatch(element[j].ToString(), @"[a-m]"))
                    {
                        char letter = element[j];
                        element = element.Remove(j, 1);
                        element = element.Insert(j, ((char)(letter + 13)).ToString());
                    }
                    else if (Regex.IsMatch(element[j].ToString(), @"[n-z]"))
                    {
                        char letter = element[j];
                        element = element.Remove(j, 1);
                        element = element.Insert(j, ((char)(letter - 13)).ToString());
                    }
                }

                while (element.Contains("  "))
                {
                    element = element.Replace("  ", " ");
                }

                result.Add(element);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}