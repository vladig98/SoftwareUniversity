using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            string input = string.Join(" ", File.ReadAllLines(path + "sample_text.txt"));

            string[] separators = new string[] { ".", ",", "!", "?", ":" };

            string[] letters = input.ToCharArray().Select(x => x.ToString()).ToArray();

            List<string> punctuation = new List<string>();

            foreach (var item in letters)
            {
                if (separators.Contains(item))
                {
                    punctuation.Add(item);
                }
            }

            File.AppendAllText(path + "output.txt", string.Join(", ", punctuation));
        }
    }
}
