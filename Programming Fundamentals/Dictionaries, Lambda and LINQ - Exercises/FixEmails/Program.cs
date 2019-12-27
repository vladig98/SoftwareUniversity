using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();
            int counter = 1;
            string prev = string.Empty;

            while (true)
            {
                if (command == "stop")
                {
                    emails = emails.Where(x => !x.Value.EndsWith("uk")).Where(x => !x.Value.EndsWith("us")).ToDictionary(x => x.Key, y => y.Value);
                    foreach (var item in emails)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    return;
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
                command = Console.ReadLine();
            }
        }
    }
}
