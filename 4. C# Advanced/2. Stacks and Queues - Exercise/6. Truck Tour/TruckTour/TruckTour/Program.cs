using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            long limit = long.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            for (long i = 0; i < limit; i++)
            {
                queue.Enqueue(Console.ReadLine());
            }

            long counter = 0;

            long petrol = 0;

            bool toBreak = false;

            while (true)
            {
                petrol = 0;
                toBreak = false;

                for (long i = 0; i < queue.Count; i++)
                {
                    long[] tokens = queue.Peek().Split(" ").Select(long.Parse).ToArray();

                    petrol += tokens[0];
                    petrol -= tokens[1];

                    if (petrol < 0)
                    {
                        toBreak = true;
                    }

                    queue.Enqueue(queue.Dequeue());
                }

                if (petrol >= 0 && toBreak == false)
                {
                    break;
                }

                queue.Enqueue(queue.Dequeue());
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
