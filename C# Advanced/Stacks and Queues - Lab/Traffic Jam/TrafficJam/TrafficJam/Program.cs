using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPass = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            int numberOfPassedCars = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    int limit = Math.Min(numberOfCarsThatCanPass, queue.Count);

                    for (int i = 0; i < limit; i++)
                    {
                        Console.WriteLine(queue.Dequeue() + " passed!");
                        numberOfPassedCars++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(numberOfPassedCars + " cars passed the crossroads.");
        }
    }
}
