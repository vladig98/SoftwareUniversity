using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers.Contains(numbers[i] + numbers[j]))
                    {
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {numbers[i] + numbers[j]}");
                        isFound = true;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
