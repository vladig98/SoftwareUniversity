using System;
using System.Collections.Generic;
using System.Linq;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOfPlants = ulong.Parse(Console.ReadLine());

            Stack<ulong> stack1 = new Stack<ulong>(Console.ReadLine().Split(" ").Select(ulong.Parse).ToArray());
            Stack<ulong> stack2 = new Stack<ulong>();

            int counter = 0;
            int currentCount = 0;
            int initialCount = stack1.Count();

            while (true)
            {
                for (int i = stack1.Count - 1; i >= 0; i--)
                {
                    ulong element = stack1.Pop();
                    if (stack1.Count > 0)
                    {
                        if (element <= stack1.Peek())
                        {
                            stack2.Push(element);
                        }
                    }
                    else
                    {
                        stack2.Push(element);
                    }
                }

                if (stack2.Count == currentCount)
                {
                    break;
                }

                if (initialCount != stack2.Count)
                {
                    counter++;
                }

                stack1.Clear();

                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }

                currentCount = stack1.Count;
            }

            Console.WriteLine(counter);
        }
    }
}
