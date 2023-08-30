using System;
using System.Collections.Generic;
using System.Linq;

namespace InfernoIII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> gemsState = gems.ToList();

            string command = Console.ReadLine();

            List<string> filters = new List<string>();

            while (command != "Forge")
            {
                string[] tokens = command.Split(";").ToArray();

                switch (tokens[0])
                {
                    case "Exclude":
                        filters.Add(tokens[1] + ";" + tokens[2]);
                        break;
                    case "Reverse":
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

                int filterValue = int.Parse(filter[1]);

                switch (filter[0])
                {
                    case "Sum Left":
                        for (int j = 0; j < gems.Count; j++)
                        {
                            if (j == 0)
                            {
                                if (gems.ElementAt(j) + 0 == filterValue)
                                {
                                    gemsState.Remove(gems.ElementAt(j));
                                }
                            }
                            else
                            {
                                if (gems.ElementAt(j) + gems.ElementAt(j - 1) == filterValue)
                                {
                                    gemsState.Remove(gems.ElementAt(j));
                                }
                            }
                        }
                        break;
                    case "Sum Right":
                        for (int j = 0; j < gems.Count; j++)
                        {
                            if (j == gems.Count - 1)
                            {
                                if (gems.ElementAt(j) + 0 == filterValue)
                                {
                                    gemsState.Remove(gems.ElementAt(j));
                                }
                            }
                            else
                            {
                                if (gems.ElementAt(j) + gems.ElementAt(j + 1) == filterValue)
                                {
                                    gemsState.Remove(gems.ElementAt(j));
                                }
                            }
                        }
                        break;
                    case "Sum Left Right":
                        for (int j = 0; j < gems.Count; j++)
                        {
                            if (j == 0)
                            {
                                if (j + 1 == gems.Count)
                                {
                                    if (gems.ElementAt(j) == filterValue)
                                    {
                                        gemsState.Remove(gems.ElementAt(j));
                                    }
                                }
                                else
                                {
                                    if (gems.ElementAt(j) + 0 + gems.ElementAt(j + 1) == filterValue)
                                    {
                                        gemsState.Remove(gems.ElementAt(j));
                                    }
                                }
                            }
                            else if (j == gems.Count - 1)
                            {
                                if (j - 1 < 0)
                                {
                                    if (gems.ElementAt(j) == filterValue)
                                    {
                                        gemsState.Remove(gems.ElementAt(j));
                                    }
                                }
                                else
                                {
                                    if (gems.ElementAt(j) + 0 + gems.ElementAt(j - 1) == filterValue)
                                    {
                                        gemsState.Remove(gems.ElementAt(j));
                                    }
                                }
                            }
                            else
                            {
                                if (gems.ElementAt(j) + gems.ElementAt(j - 1) + gems.ElementAt(j + 1) == filterValue)
                                {
                                    gemsState.Remove(gems.ElementAt(j));
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", gemsState));
        }
    }
}
