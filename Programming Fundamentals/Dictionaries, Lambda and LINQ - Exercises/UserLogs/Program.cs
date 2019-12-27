using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(" ").ToArray();

                string username = tokens[2].Split("=")[1];
                string ip = tokens[0].Split("=")[1];

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip]++;
                    }
                    else
                    {
                        users[username].Add(ip, 1);
                    }
                }
                else
                {
                    users.Add(username, new Dictionary<string, int>() { { ip, 1 } });
                }

                command = Console.ReadLine();
            }

            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key}:");
                Console.WriteLine($"{string.Join(", ", item.Value.Select(x => string.Format($"{x.Key} => {x.Value}")).ToArray())}.");
            }
        }
    }
}
