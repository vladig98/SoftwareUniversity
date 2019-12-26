using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isFound = false;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
