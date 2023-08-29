using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = Console.ReadLine().Split(" ").ToArray();
            string[] words2 = Console.ReadLine().Split(" ").ToArray();

            int maxLength = Math.Min(words1.Length, words2.Length);

            int counterForwards = 0;
            int counterBackwards = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (words1[i] == words2[i])
                {
                    counterForwards++;
                }
                else
                {
                    break;
                }
            }

            words1 = words1.Reverse().ToArray();
            words2 = words2.Reverse().ToArray();

            for (int i = 0; i < maxLength; i++)
            {
                if (words1[i] == words2[i])
                {
                    counterBackwards++;
                }
                else
                {
                    break;
                }
            }

            if (counterForwards >= counterBackwards)
            {
                Console.WriteLine(counterForwards);
            }
            else
            {
                Console.WriteLine(counterBackwards);
            }
        }
    }
}
