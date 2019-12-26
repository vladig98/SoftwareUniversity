using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            int maxLength = 0;
            int lastIndex = -1;
            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int k = 0; k < i; k++)
                {
                    if (numbers[k] < numbers[i] && len[k] + 1 > len[i])
                    {
                        len[i] = len[k] + 1;
                        prev[i] = k;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            int[] LIS = new int[maxLength];
            int currentIndex = maxLength - 1;

            while (lastIndex != -1)
            {
                LIS[currentIndex] = numbers[lastIndex];
                currentIndex--;
                lastIndex = prev[lastIndex];
            }

            Console.WriteLine(string.Join(" ", LIS));
        }
    }
}
