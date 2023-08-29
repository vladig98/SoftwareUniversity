using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WritetoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            string[] input = File.ReadAllLines(path + "sample_text.txt");

            string[] separators = new string[] { ".", ",", "!", "?", ":" };

            List<string> lines = new List<string>();

            foreach (var item in input)
            {
                string[] words = item.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string connected = string.Join(" ", words);
                words = connected.Split(" \"", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                lines.Add(string.Join(" ", words));
            }

            File.AppendAllText(path + "output.txt", string.Join(Environment.NewLine + Environment.NewLine, lines.Where(x => x != string.Empty).Select(x => x + "\"").ToArray()));
        }
    }
}
