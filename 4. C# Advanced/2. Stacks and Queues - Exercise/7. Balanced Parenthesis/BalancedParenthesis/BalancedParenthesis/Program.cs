using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string element = input[i].ToString();

                if (element == "(" || element == "{" || element == "[")
                {
                    stack.Push(element);
                }
                else if (element == ")" || element == "}" || element == "]")
                {
                    if (stack.Count() > 0)
                    {
                        if (Inversed(element) == stack.Peek())
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (stack.Count() > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }

        static string Inversed(string element)
        {
            switch (element)
            {
                case ")":
                    return "(";
                case "}":
                    return "{";
                case "]":
                    return "[";
                default:
                    return "";
            }
        }
    }
}
