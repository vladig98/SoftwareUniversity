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
            string path = @"..\..\..\";
            string[] words = File.ReadAllText(path + "words.txt").Split(" ").ToArray();
            string[] text = File.ReadAllLines(path + "text.txt");
            string[] wordsFromText = string.Join(" ", text).Split(new[] { " ", ",", ".", "...", ":", "!", "-", "?" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower()).ToArray();
            words = words.Select(x => x.ToLower()).ToArray();

            Dictionary<string, int> counters = new Dictionary<string, int>();

            for (int i = 0; i < wordsFromText.Length; i++)
            {
                if (words.Contains(wordsFromText[i]))
                {
                    if (counters.ContainsKey(wordsFromText[i]))
                    {
                        counters[wordsFromText[i]]++;
                    }
                    else
                    {
                        counters.Add(wordsFromText[i], 1);
                    }
                }
            }

            counters = counters.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            string[] results = counters.Select(x => x.Key + " - " + x.Value).ToArray();

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
