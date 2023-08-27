using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int numberOfElements = int.Parse(input.Split(" ")[0]);
            int numberOfElementsToRemove = int.Parse(input.Split(" ")[1]);
            int numberToLookFor = int.Parse(input.Split(" ")[2]);

            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
