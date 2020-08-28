using System;
using System.Collections.Generic;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> results = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                results.Add(GetEscapeSequence(input[i]));
            }

            Console.WriteLine(string.Join("", results));
        }

        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4").ToLower();
        }
    }
}
