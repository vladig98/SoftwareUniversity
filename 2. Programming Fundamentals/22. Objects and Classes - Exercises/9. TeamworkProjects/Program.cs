using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split("-").ToArray();

                if (teams.Any(x => x.Name == tokens[1]))
                {
                    Console.WriteLine($"Team {tokens[1]} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator == tokens[0]))
                {
                    Console.WriteLine($"{tokens[0]} cannot create another team!");
                    continue;
                }

                Team team = new Team();
                team.Creator = tokens[0];
                team.Name = tokens[1];
                team.Members.Add(tokens[0]);

                teams.Add(team);

                Console.WriteLine($"Team {tokens[1]} has been created by {tokens[0]}!");
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] tokens = command.Split("->").ToArray();

                if (!teams.Any(x => x.Name == tokens[1]))
                {
                    Console.WriteLine($"Team {tokens[1]} does not exist!");
                    command = Console.ReadLine();
                    continue;
                }

                if (teams.Any(x => x.Members.Any(y => y == tokens[0])))
                {
                    Console.WriteLine($"Member {tokens[0]} cannot join team {tokens[1]}!");
                    command = Console.ReadLine();
                    continue;
                }

                teams.FirstOrDefault(x => x.Name == tokens[1]).Members.Add(tokens[0]);

                command = Console.ReadLine();
            }

            teams = teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name).ToList();

            foreach (var item in teams)
            {
                if (item.Members.Count > 1)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine($"- {item.Members.First()}");
                    foreach (var item2 in item.Members.Skip(1).OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {item2}");
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            Console.WriteLine(string.Join("\n", teams.Where(x => x.Members.Count <= 1).Select(x => x.Name)));
        }

        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team()
            {
                this.Members = new List<string>();
            }
        }
    }
}
