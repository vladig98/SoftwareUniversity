using System;
using System.Collections.Generic;
using System.Linq;

namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            

            while (input != "END")
            {
                List<string> pairs = new List<string>();

                pairs.AddRange(input.Split(new[] { "&", "?" }, StringSplitOptions.RemoveEmptyEntries).ToList());

                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                for (int i = 0; i < pairs.Count; i++)
                {
                    string keyValue = pairs.ElementAt(i);

                    keyValue = keyValue.Replace("+", " ");
                    keyValue = keyValue.Replace("%20", " ");
                    while (keyValue.Contains("  "))
                    {
                        keyValue = keyValue.Replace("  ", " ");
                    }

                    if (keyValue.Contains("="))
                    {
                        string[] tokens = keyValue.Split("=").Select(x => x.Trim()).ToArray();

                        if (keyValuePairs.Keys.Any(x => x == tokens[0]))
                        {
                            keyValuePairs[tokens[0]] = keyValuePairs[tokens[0]] + ", " + tokens[1];
                        }
                        else
                        {
                            keyValuePairs.Add(tokens[0], tokens[1]);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                foreach (var item in keyValuePairs)
                {
                    Console.Write($"{item.Key}=[{item.Value}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
