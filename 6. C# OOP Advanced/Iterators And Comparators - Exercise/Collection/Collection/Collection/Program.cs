using System;
using System.Linq;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListyIterator<string> iterator = null;

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                switch (tokens[0])
                {
                    case "Create":
                        iterator = new ListyIterator<string>(tokens.Skip(1).ToList());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "PrintAll":
                        iterator.PrintAll();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
