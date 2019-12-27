using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(" ").ToList<string>();

            Random rnd = new Random();

            while (words.Count > 0)
            {
                int index = rnd.Next(0, words.Count);
                Console.WriteLine(words.ElementAt(index));
                words.RemoveAt(index);
            }
        }
    }
}
