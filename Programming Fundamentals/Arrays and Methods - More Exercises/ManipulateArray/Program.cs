using System;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split(" ").ToArray();

                switch (tokens[0])
                {
                    case "Reverse":
                        words = words.Reverse().Select(x => x).ToArray();
                        break;
                    case "Distinct":
                        words = words.Distinct().Select(x => x).ToArray();
                        break;
                    case "Replace":
                        words[int.Parse(tokens[1])] = tokens[2];
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
