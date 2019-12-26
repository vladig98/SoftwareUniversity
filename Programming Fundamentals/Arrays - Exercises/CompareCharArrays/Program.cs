using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars1 = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
            char[] chars2 = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();

            string word1 = string.Join("", chars1);
            string word2 = string.Join("", chars2);

            if (word1.CompareTo(word2) <= 0)
            {
                Console.WriteLine(word1);
                Console.WriteLine(word2);
            }
            else
            {
                Console.WriteLine(word2);
                Console.WriteLine(word1);
            }
        }
    }
}
