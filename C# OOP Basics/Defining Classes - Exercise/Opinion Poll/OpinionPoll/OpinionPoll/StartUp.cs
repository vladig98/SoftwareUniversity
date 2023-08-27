using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                people.Add(new Person(inputTokens[0], int.Parse(inputTokens[1])));
            }

            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
