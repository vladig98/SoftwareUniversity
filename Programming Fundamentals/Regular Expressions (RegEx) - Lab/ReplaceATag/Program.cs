using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a \S+>|<a\S+>";

            string input = Console.ReadLine();

            while (input != "end")
            {
                input = input.Trim();
                if (Regex.IsMatch(input, pattern))
                {
                    int indexOfBeginning = input.IndexOf("<a");
                    int indexOfEnding = 0;
                    for (int i = indexOfBeginning; i < input.Length; i++)
                    {
                        if (input[i] == '>')
                        {
                            indexOfEnding = i;
                            break;
                        }
                    }
                    input = input.Remove(indexOfEnding, 1);
                    input = input.Insert(indexOfEnding, "]");
                    input = input.Replace("<a", "[URL");
                    input = input.Replace("</a>", "[/URL]");
                }

                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
