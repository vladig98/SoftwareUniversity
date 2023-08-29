using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int counter = 1;
            string prev = string.Empty;

            Dictionary<string, int> elements = new Dictionary<string, int>();

            while (true)
            {
                if (command == "stop")
                {
                    foreach (var item in elements)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    return;
                }
                if (counter % 2 == 0)
                {
                    elements[prev] += int.Parse(command);
                }
                else
                {
                    if (!elements.ContainsKey(command))
                    {
                        elements.Add(command, 0);
                    }
                }
                counter++;
                prev = command;
                command = Console.ReadLine();
            }
        }
    }
}
