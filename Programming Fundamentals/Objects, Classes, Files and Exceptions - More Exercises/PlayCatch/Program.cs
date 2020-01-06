using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int exceptions = 0;

            while (exceptions < 3)
            {
                string command = Console.ReadLine();

                string[] tokens = command.Split(" ").ToArray();

                switch (tokens[0])
                {
                    case "Replace":
                        int index = 0;
                        int value = 0;
                        try
                        {
                            index = int.Parse(tokens[1]);
                            value = int.Parse(tokens[2]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                            continue;
                        }
                        try
                        {
                            numbers[index] = value;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptions++;
                        }
                        break;
                    case "Print":
                        int startIndex = 0;
                        int endIndex = 0;
                        try
                        {
                            startIndex = int.Parse(tokens[1]);
                            endIndex = int.Parse(tokens[2]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                            continue;
                        }
                        try
                        {
                            List<int> result = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                result.Add(numbers[i]);
                            }
                            Console.WriteLine(string.Join(", ", result));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptions++;
                        }
                        break;
                    case "Show":
                        int elementIndex = 0;
                        try
                        {
                            elementIndex = int.Parse(tokens[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                            continue;
                        }
                        try
                        {
                            Console.WriteLine(numbers[elementIndex]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptions++;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
