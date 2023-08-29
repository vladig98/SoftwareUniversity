using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderbyAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (command != "End")
            {
                string[] tokens = command.Split(" ").ToArray();

                Person person = new Person();

                person.Name = tokens[0];
                person.ID = tokens[1];
                person.Age = int.Parse(tokens[2]);

                people.Add(person);

                command = Console.ReadLine();
            }

            people = people.OrderBy(x => x.Age).ToList();

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Age} years old.");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
    }
}
