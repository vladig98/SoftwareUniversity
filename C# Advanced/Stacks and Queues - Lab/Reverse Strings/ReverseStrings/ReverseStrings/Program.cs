using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i].ToString());
            }

            string reversed = string.Empty;

            while (stack.Count > 0)
            {
                reversed += stack.Pop();
            }

            Console.WriteLine(reversed);
        }
    }
}
