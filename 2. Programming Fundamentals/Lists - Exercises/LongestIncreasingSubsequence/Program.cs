using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nums.Length;

            int[] len = new int[n];
            List<int>[] lis = new List<int>[n];

            for (int i = 0; i < len.Length; i++)
            {
                len[i] = 1;
                lis[i] = new List<int>() { nums[i] };
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        if (len[i] < len[j] + 1)
                        {
                            len[i] = len[j] + 1;
                            lis[i] = new List<int>();
                            lis[i].AddRange(lis[j]);
                            lis[i].Add(nums[i]);
                        }
                    }
                }
            }

            var longest = new List<int>();

            for (int i = 0; i < lis.Length; i++)
            {
                if (longest.Count < lis[i].Distinct().Count())
                {
                    longest = lis[i].Distinct().ToList();
                }
            }

            longest = longest.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", longest));
        }
    }
}
