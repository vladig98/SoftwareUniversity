using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("words.txt");

            Dictionary<string, int> words = new Dictionary<string, int>();

            using (reader)
            {
                string input = reader.ReadLine();

                while (input != null)
                {
                    words.Add(input, 0);

                    input = reader.ReadLine();
                }
            }

            reader = new StreamReader("text.txt");

            using (reader)
            {
                string input = reader.ReadLine();

                while (input != null)
                {
                    string[] tokens = input.Split(new[] { "-", ",", ".", "?", "!", " ", "..." }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Count; i++)
                    {
                        string key = words.ElementAt(i).Key;

                        words[key] += tokens.Where(x => x.ToLower() == key.ToLower()).Count();
                    }

                    input = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter("result.txt");

            using (writer)
            {
                words = words.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                for (int i = 0; i < words.Count; i++)
                {
                    KeyValuePair<string, int> element = words.ElementAt(i);

                    writer.WriteLine(element.Key + " - " + element.Value);
                }
            }
        }
    }
}
