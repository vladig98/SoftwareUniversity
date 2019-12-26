using System;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").ToArray();

            string command = Console.ReadLine();

            while (command != "END")
            {
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
                        if (int.Parse(tokens[1]) >= words.Length || int.Parse(tokens[1]) < 0)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        words[int.Parse(tokens[1])] = tokens[2];
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
