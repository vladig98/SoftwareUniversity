using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            List<string> filters = new List<string>();

            while (command != "Print")
            {
                string[] tokens = command.Split(";").ToArray();

                switch (tokens[0])
                {
                    case "Add filter":
                        filters.Add(tokens[1] + ";" + tokens[2]);
                        break;
                    case "Remove filter":
                        filters.Remove(tokens[1] + ";" + tokens[2]);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < filters.Count; i++)
            {
                string[] filter = filters.ElementAt(i).Split(";").ToArray();

                Predicate<string> startsWith = x => x.StartsWith(filter[1]);
                Predicate<string> endsWith = x => x.EndsWith(filter[1]);
                Predicate<string> length = x => x.Length == int.Parse(filter[1]);
                Predicate<string> contains = x => x.Contains(filter[1]);

                switch (filter[0])
                {
                    case "Starts with":
                        people.RemoveAll(x => startsWith(x));
                        break;
                    case "Ends with":
                        people.RemoveAll(x => endsWith(x));
                        break;
                    case "Length":
                        people.RemoveAll(x => length(x));
                        break;
                    case "Contains":
                        people.RemoveAll(x => contains(x));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", people));
        }
    }
}
