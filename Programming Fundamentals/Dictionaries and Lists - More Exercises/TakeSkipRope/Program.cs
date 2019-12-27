using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] digits = input.ToCharArray().Where(x => x > 47 && x < 58).Select(x => int.Parse(x.ToString())).ToArray();
            string[] chars = input.ToCharArray().Where(x => x < 48 || x > 57).Select(x => x.ToString()).ToArray();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            int skipped = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]); 
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }

            string result = string.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                string newPart = string.Join("", chars.Skip(skipped).Take(takeList.ElementAt(i)));
                result += newPart;
                skipped += skipList.ElementAt(i) + newPart.Length;
            }

            Console.WriteLine(result);
        }
    }
}
