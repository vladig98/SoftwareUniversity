using System;
using System.Collections.Generic;

namespace SequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<long> queue = new Queue<long>();
            Queue<long> finalQueue = new Queue<long>();

            long number = long.Parse(Console.ReadLine());

            queue.Enqueue(number);

            for (int i = 1; i < 50; i += 3)
            {
                long element = queue.Dequeue();
                finalQueue.Enqueue(element);
                queue.Enqueue(element + 1);
                queue.Enqueue(2 * element + 1);
                queue.Enqueue(element + 2);
            }

            while (finalQueue.Count < 50)
            {
                finalQueue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(string.Join(" ", finalQueue));
        }
    }
}
