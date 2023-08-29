using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[a-zA-Z]+(?!\\\|\<)|(?!=\\\|\<)[a-zA-Z]+$";

            string[] keys = Regex.Matches(Console.ReadLine(), pattern).Select(x => x.Value).ToArray();

            string[] matches = Regex.Matches(Console.ReadLine(), keys[0] + @".*?" + keys[1]).Select(x => x.Value).ToArray();

            string result = string.Empty;

            for (int i = 0; i < matches.Length; i++)
            {
                result += matches[i].Remove(0, keys[0].Length).Remove(matches[i].Length - keys[1].Length - keys[0].Length, keys[1].Length);
            }

            if (result != string.Empty)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
