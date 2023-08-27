using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().ToCharArray().Select(x => x.ToString()).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "(")
                {
                    stack.Push(i);
                }
                else if (tokens[i] == ")")
                {
                    int index = stack.Pop();
                    Console.WriteLine(string.Join("", tokens.Skip(index).Take((i - index) + 1).ToArray()));
                }
            }
        }
    }
}
