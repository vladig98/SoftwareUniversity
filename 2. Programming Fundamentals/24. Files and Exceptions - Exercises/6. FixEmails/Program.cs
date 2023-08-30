using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] commands = File.ReadAllLines(path + "input.txt");
            Dictionary<string, string> emails = new Dictionary<string, string>();
            int counter = 1;
            string prev = string.Empty;

            List<string> results = new List<string>();

            foreach (var command in commands)
            {
                if (command == "stop")
                {
                    emails = emails.Where(x => !x.Value.EndsWith("uk")).Where(x => !x.Value.EndsWith("us")).ToDictionary(x => x.Key, y => y.Value);
                    foreach (var item in emails)
                    {
                        results.Add($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                if (counter % 2 == 0)
                {
                    emails[prev] = command;
                }
                else
                {
                    emails.Add(command, string.Empty);
                }
                counter++;
                prev = command;
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
