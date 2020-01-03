using System;
using System.Collections.Generic;
using System.Linq;

namespace MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<User> users = new List<User>();

            while (command != "end of dates")
            {
                string[] tokens = command.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                User user = users.Any(x => x.Name == tokens[0]) ? users.FirstOrDefault(x => x.Name == tokens[0]) : new User();
                user.Name = tokens[0];
                user.Dates.AddRange(tokens.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", null)).ToList());

                if (!users.Any(x => x.Name == tokens[0]))
                {
                    users.Add(user);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "end of comments")
            {
                string[] tokens = command.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (users.Any(x => x.Name == tokens[0]))
                {
                    users.FirstOrDefault(x => x.Name == tokens[0]).Comments.AddRange(tokens.Skip(1));
                }

                command = Console.ReadLine();
            }

            users = users.OrderBy(x => x.Name).ToList();

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Comments:");
                foreach (var item2 in item.Comments.Distinct())
                {
                    Console.WriteLine($"- {item2}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var item2 in item.Dates.OrderBy(x => x).ToList())
                {
                    Console.WriteLine($"-- {item2.ToString("dd/MM/yyyy")}");
                }
            }
        }

        public class User
        {
            public string Name { get; set; }
            public List<DateTime> Dates { get; set; }
            public List<string> Comments { get; set; }

            public User()
            {
                this.Dates = new List<DateTime>();
                this.Comments = new List<string>();
            }
        }
    }
}
