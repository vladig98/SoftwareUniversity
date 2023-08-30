using System;
using System.Linq;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            while (input != "END")
            {
                string[] tokens = input.Split(new[] { " ", ","}, StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Push":
                        stack.Push(tokens.Skip(1).Select(int.Parse).ToList());
                        break;
                    case "Pop":
                        stack.Pop();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
