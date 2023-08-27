using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(" ").ToArray();
            int hotPotatoRound = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(players);

            while (queue.Count > 1)
            {
                for (int i = 1; i < hotPotatoRound; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine("Removed " + queue.Dequeue());
            }

            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
