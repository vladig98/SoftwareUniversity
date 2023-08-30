using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> people = new List<Person>();

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }

            int indexOfPersonToCompare = int.Parse(Console.ReadLine());
            Person person = people[indexOfPersonToCompare - 1];

            int numberOfMatches = people.Where(x => x.CompareTo(person) == 0).Count();

            string output =  numberOfMatches > 1 ? $"{numberOfMatches} {people.Count - numberOfMatches} {people.Count}" : "No matches";

            Console.WriteLine(output);
        }
    }
}
