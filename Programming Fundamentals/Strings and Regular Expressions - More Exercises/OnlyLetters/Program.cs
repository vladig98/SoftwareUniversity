using System;
using System.Text.RegularExpressions;

namespace OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (Regex.IsMatch(input[i].ToString(), @"\d"))
                {
                    input = input.Remove(i, 1);
                    i--;
                    if (!Regex.IsMatch(input[i + 1].ToString(), @"\d"))
                    {
                        input = input.Insert(i + 1, input[i + 1].ToString());
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
