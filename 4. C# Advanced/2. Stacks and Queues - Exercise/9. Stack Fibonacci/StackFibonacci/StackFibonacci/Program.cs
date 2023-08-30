using System;
using System.Collections.Generic;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<ulong> stack = new Stack<ulong>();

            stack.Push(0);
            stack.Push(1);

            int fibonacciNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < fibonacciNumber; i++)
            {
                ulong peeked = stack.Peek();
                ulong number1 = stack.Pop();
                ulong number2 = stack.Pop();
                stack.Push(peeked);
                stack.Push(number1 + number2);
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
