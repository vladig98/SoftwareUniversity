using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] inputTokens = input.Split(":");

                if (!contests.ContainsKey(inputTokens[0]))
                {
                    contests.Add(inputTokens[0], inputTokens[1]);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] inputTokens = input.Split("=>");

                if (contests.ContainsKey(inputTokens[0]))
                {
                    if (contests[inputTokens[0]] == inputTokens[1])
                    {
                        if (users.ContainsKey(inputTokens[2]))
                        {
                            if (users[inputTokens[2]].ContainsKey(inputTokens[0]))
                            {
                                if (users[inputTokens[2]][inputTokens[0]] < int.Parse(inputTokens[3]))
                                {
                                    users[inputTokens[2]][inputTokens[0]] = int.Parse(inputTokens[3]);
                                }
                            }
                            else
                            {
                                users[inputTokens[2]].Add(inputTokens[0], int.Parse(inputTokens[3]));
                            }
                        }
                        else
                        {
                            users.Add(inputTokens[2], new Dictionary<string, int> { { inputTokens[0], int.Parse(inputTokens[3]) } });
                        }
                    }
                }

                input = Console.ReadLine();
            }

            KeyValuePair<string, Dictionary<string, int>> bestStudent = users.OrderByDescending(x => x.Value.Sum(y => y.Value)).FirstOrDefault();

            users = users.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");

                foreach (var contest in user.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
