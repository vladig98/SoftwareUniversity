using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < limit; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                switch (input[0])
                {
                    case "1":
                        stack.Push(int.Parse(input[1]));
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        Console.WriteLine(stack.Max());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
