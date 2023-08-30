using System;
using System.Collections.Generic;
using System.IO;

namespace IndexofLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            string[] input = File.ReadAllLines(path + "input.txt");
            List<string> results = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] letters = input[i].ToCharArray();
                foreach (var item in letters)
                {
                    results.Add($"{item} -> {item - 97}");
                }
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
