using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(" ");

            int numberOfElements = int.Parse(tokens[0]);
            int numberOfElementsToRemove = int.Parse(tokens[1]);
            int numberToLookFor = int.Parse(tokens[2]);

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);

                    return;
                }

                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);

                return;
            }

            if (queue.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
