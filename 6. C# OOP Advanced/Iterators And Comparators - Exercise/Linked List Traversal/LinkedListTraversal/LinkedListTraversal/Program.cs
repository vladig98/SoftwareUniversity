using System;

namespace LinkedListTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            LinkedListTraversal.LinkedList<int> list = new LinkedListTraversal.LinkedList<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                switch (tokens[0])
                {
                    case "Add":
                        list.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join(' ', list));
        }
    }
}
