using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NameComparator nameComparator = new NameComparator();
            AgeComparator ageComparator = new AgeComparator();  
            SortedSet<Person> peopleComparedByName = new SortedSet<Person>(nameComparator);
            SortedSet<Person> peopleComparedByAge = new SortedSet<Person>(ageComparator);

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                peopleComparedByAge.Add(new Person(name, age));
                peopleComparedByName.Add(new Person(name, age));
            }

            foreach (Person person in peopleComparedByName)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            foreach (Person person in peopleComparedByAge)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
