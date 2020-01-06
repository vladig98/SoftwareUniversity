using System;
using System.Collections.Generic;
using System.IO;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] commands = File.ReadAllLines(path + "input.txt");
            int counter = 1;
            string prev = string.Empty;

            Dictionary<string, int> elements = new Dictionary<string, int>();
            List<string> results = new List<string>();

            foreach (var command in commands)
            {
                if (command == "stop")
                {
                    foreach (var item in elements)
                    {
                        results.Add($"{item.Key} -> {item.Value}");
                    }
                    break;
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
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
