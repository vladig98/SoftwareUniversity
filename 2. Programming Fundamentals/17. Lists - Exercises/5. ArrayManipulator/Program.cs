using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            string cmd = Console.ReadLine();

            while (true)
            {
                string[] tokens = cmd.Split(" ");

                switch (tokens[0])
                {
                    case "add":
                        if (int.Parse(tokens[1]) > numbers.Count)
                        {
                            break;
                        }
                        numbers.Insert(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "addMany":
                        if (int.Parse(tokens[1]) > numbers.Count)
                        {
                            break;
                        }
                        int nextNumber = 2;
                        for (int i = 0; i < tokens.Length - 2; i++)
                        {
                            int index = int.Parse(tokens[1]) + i;
                            numbers.Insert(index, int.Parse(tokens[nextNumber]));
                            nextNumber++;
                        }
                        break;
                    case "contains":
                        Console.WriteLine(numbers.IndexOf(numbers.FirstOrDefault(x => x == int.Parse(tokens[1]))));
                        break;
                    case "remove":
                        if (int.Parse(tokens[1]) > numbers.Count)
                        {
                            break;
                        }
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "shift":
                        int num = int.Parse(tokens[1]) % numbers.Count;
                        int[] temp = numbers.Take(num).ToArray();
                        numbers.RemoveRange(0, num);
                        numbers.AddRange(temp);
                        break;
                    case "sumPairs":
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            numbers[i] = numbers.ElementAt(i) + numbers.ElementAt(i + 1);
                            numbers.RemoveAt(i + 1);
                        }
                        break;
                    case "print":
                        Console.WriteLine($"[{string.Join(", ", numbers)}]");
                        return;
                    default:
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
