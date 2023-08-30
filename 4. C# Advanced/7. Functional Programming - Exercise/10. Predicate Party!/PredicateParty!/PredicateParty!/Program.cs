using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] tokens = command.Split();

                Predicate<string> startsWith = c => c.StartsWith(tokens[2].ToString());
                Predicate<string> endsWith = c => c.EndsWith(tokens[2].ToString());
                Predicate<string> length = c => c.Length == int.Parse(tokens[2]);

                switch (tokens[0])
                {
                    case "Remove":
                        switch (tokens[1])
                        {
                            case "StartsWith":
                                people.RemoveAll(x => startsWith(x));
                                break;
                            case "EndsWith":
                                people.RemoveAll(x => endsWith(x));
                                break;
                            case "Length":
                                people.RemoveAll(x => length(x));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Double":
                        List<string> doubled = new List<string>();
                        switch (tokens[1])
                        {
                            case "StartsWith":
                                doubled = people.Where(x => startsWith(x)).ToList();
                                for (int i = 0; i < people.Count; i++)
                                {
                                    if (doubled.Contains(people.ElementAt(i)))
                                    {
                                        people.Insert(i, people.ElementAt(i));
                                        i++;
                                    }
                                }
                                break;
                            case "EndsWith":
                                doubled = people.Where(x => endsWith(x)).ToList();
                                for (int i = 0; i < people.Count; i++)
                                {
                                    if (doubled.Contains(people.ElementAt(i)))
                                    {
                                        people.Insert(i, people.ElementAt(i));
                                        i++;
                                    }
                                }
                                break;
                            case "Length":
                                doubled = people.Where(x => length(x)).ToList();
                                for (int i = 0; i < people.Count; i++)
                                {
                                    if (doubled.Contains(people.ElementAt(i)))
                                    {
                                        people.Insert(i, people.ElementAt(i));
                                        i++;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
                return;
            }

            Console.WriteLine(string.Join(", ", people) + " are going to the party!");
        }
    }
}
