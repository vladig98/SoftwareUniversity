using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < Math.Max(numbers1.Length, numbers2.Length); i++)
            {
                Console.Write($"{numbers1[i % numbers1.Length] + numbers2[i % numbers2.Length]} ");
            }
        }
    }
}
