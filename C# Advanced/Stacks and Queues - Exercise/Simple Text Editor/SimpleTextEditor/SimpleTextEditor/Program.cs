using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string textField = string.Empty;

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();
                int operation = int.Parse(tokens[0]);

                switch (operation)
                {
                    case 1:
                        stack.Push(textField);
                        textField += tokens[1];
                        break;
                    case 2:
                        stack.Push(textField);
                        textField = textField.Substring(0, textField.Length - int.Parse(tokens[1]));
                        break;
                    case 3:
                        Console.WriteLine(textField[int.Parse(tokens[1]) - 1]);
                        break;
                    case 4:
                        textField = stack.Pop();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
