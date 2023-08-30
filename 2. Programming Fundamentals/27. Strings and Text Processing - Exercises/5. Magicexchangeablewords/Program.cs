using System;
using System.Collections.Generic;
using System.Linq;

namespace Magicexchangeablewords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            string word1 = input[0];
           string word2 = input[1];

           Console.WriteLine((AreExchangeableWords(word1, word2)).ToString().ToLower());
        }

        public static bool AreExchangeableWords(string word1, string word2)
        {
            Dictionary<char, char> variables = new Dictionary<char, char>();

            if (word2.Length < word1.Length)
            {
                var temp = word1;
                word1 = word2;
                word2 = temp;
            }

            for (int i = 0; i < word1.Length; i++)
            {
                if (variables.ContainsKey(word1[i]))
                {
                    if (variables[word1[i]] != word2[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (!variables.Values.Any(x => x == word2[i]))
                    {
                        variables.Add(word1[i], word2[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            int difference = word2.Length - word1.Length;

            if (difference > 0)
            {
                for (int i = difference - 1; i < word2.Length; i++)
                {
                    if (!variables.Values.Any(x => x == word2[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
