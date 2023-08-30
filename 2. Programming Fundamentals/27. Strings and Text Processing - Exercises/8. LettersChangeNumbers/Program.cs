using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] substrings = Console.ReadLine().Split(new[] { " ", "\t"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal result = 0;

            for (int i = 0; i < substrings.Length; i++)
            {
                decimal number = decimal.Parse(substrings[i].Remove(0, 1).Remove(substrings[i].Length - 2, 1));
                char start = substrings[i][0];
                char end = substrings[i][substrings[i].Length - 1];

                if (start > 64 && start < 91)
                {
                    number /= start.ToString().ToUpper()[0] - 64;
                }
                else if (start > 96 && start < 172)
                {
                    number *= start.ToString().ToUpper()[0] - 64;
                }

                if (end > 64 && end < 91)
                {
                    number -= end.ToString().ToUpper()[0] - 64;
                }
                else if (end > 96 && end < 172)
                {
                    number += end.ToString().ToUpper()[0] - 64;
                }

                result += number;
            }

            Console.WriteLine(result.ToString("F2"));
        }
    }
}
