using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Town> towns = new List<Town>();

            while (command != "End")
            {
                string[] tokens = command.Split("=>").ToArray();

                if (tokens.Length > 1)
                {
                    Town town = new Town();
                    town.Name = tokens[0].Trim();
                    string seats = tokens[1].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                    town.Seats = int.Parse(seats);
                    towns.Add(town);
                }
                else
                {
                    tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Student student = new Student();
                    student.Name = tokens[0].Trim();
                    student.Email = tokens[1].Trim();
                    student.EntryDate = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", null);
                    towns.Last().Students.Add(student);
                }

                command = Console.ReadLine();
            }

            towns = towns.OrderBy(x => x.Name).ToList();

            Console.WriteLine($"Created {towns.Sum(x => Math.Ceiling(x.Students.Count / (double)x.Seats))} groups in {towns.Count} towns:");

            foreach (var item in towns)
            {
                int counter = 0;
                while (counter < item.Students.Count)
                {
                    Console.WriteLine($"{item.Name} => {string.Join(", ", item.Students.OrderBy(x => x.EntryDate).ThenBy(x => x.Name).ThenBy(x => x.Email).Skip(counter).Take(item.Seats).Select(x => x.Email))}");
                    counter += item.Seats;
                }
            }
        }

        public class Town
        {
            public int Seats { get; set; }

            public string Name { get; set; }

            public List<Student> Students { get; set; }

            public Town()
            {
                this.Students = new List<Student>();
            }
        }

        public class Student
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public DateTime EntryDate { get; set; }
        }
    }
}
