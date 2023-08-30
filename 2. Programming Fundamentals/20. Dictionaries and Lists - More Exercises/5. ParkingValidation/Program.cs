using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();

                if (tokens[0] == "register")
                {
                    if (users.ContainsKey(tokens[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[tokens[1]]}");
                        continue;
                    }
                    else
                    {
                        if (tokens[2].Length != 8)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                            continue;
                        }
                        char[] number = tokens[2].ToCharArray();
                        if (number[0] < 65 || number[0] > 90)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                            continue;
                        }
                        if (number[1] < 65 || number[1] > 90)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                            continue;
                        }
                        if (number[6] < 65 || number[6] > 90)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                            continue;
                        }
                        if (number[7] < 65 || number[7] > 90)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                            continue;
                        }
                        bool toContinue = false;
                        for (int j = 2; j < number.Length - 2; j++)
                        {
                            if (number[j] < 48 || number[j] > 57)
                            {
                                Console.WriteLine($"ERROR: invalid license plate {tokens[2]}");
                                toContinue = true;
                                break;
                            }
                        }

                        if (toContinue)
                        {
                            continue;
                        }

                        if (users.Any(x => x.Value == tokens[2]))
                        {
                            Console.WriteLine($"ERROR: license plate {tokens[2]} is busy");
                            continue;
                        }
                        users.Add(tokens[1], tokens[2]);
                        Console.WriteLine($"{tokens[1]} registered {tokens[2]} successfully");
                    }
                }
                else
                {
                    if (!users.Any(x => x.Key == tokens[1]))
                    {
                        Console.WriteLine($"ERROR: user {tokens[1]} not found");
                        continue;
                    }
                    else
                    {
                        users.Remove(tokens[1]);
                        Console.WriteLine($"user {tokens[1]} unregistered successfully");
                    }
                }
            }

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
