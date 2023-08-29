using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new[] { ",", ".", " ", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();

            foreach (var item in words)
            {
                if (item == string.Join("", item.ToCharArray().Reverse()))
                {
                    result.Add(item);
                }
            }

            result = result.Distinct().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
