using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string[] tokens = command.Split(" ").ToArray();

                switch (tokens[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(tokens[1]))
                        {
                            phonebook[tokens[1]] = tokens[2];
                        }
                        else
                        {
                            phonebook.Add(tokens[1], tokens[2]);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(tokens[1]))
                        {
                            KeyValuePair<string, string> person = phonebook.FirstOrDefault(x => x.Key == tokens[1]);
                            Console.WriteLine($"{person.Key} -> {person.Value}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {tokens[1]} does not exist.");
                        }
                        break;
                    case "END":
                        return;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
