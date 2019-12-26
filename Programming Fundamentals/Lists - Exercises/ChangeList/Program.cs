using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            string cmd = Console.ReadLine();

            while (true)
            {
                string[] tokens = cmd.Split(" ").ToArray();

                switch (tokens[0])
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                    case "Odd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0).ToArray()));
                        return;
                    case "Even":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0).ToArray()));
                        return;
                    default:
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
