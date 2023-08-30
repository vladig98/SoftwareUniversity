using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                Person person = new Person(name, age);

                if (!peopleSortedSet.Any(x => x.Equals(person)))
                {
                    peopleSortedSet.Add(person);
                }

                if (!peopleHashSet.Any(x => x.GetHashCode() == person.GetHashCode()))
                {
                    peopleHashSet.Add(person);
                }
            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
