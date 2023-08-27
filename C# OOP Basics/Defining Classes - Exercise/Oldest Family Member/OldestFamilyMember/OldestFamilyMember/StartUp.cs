using System;

namespace OldestFamilyMember
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");

                Person person = new Person(inputTokens[0], int.Parse(inputTokens[1]));

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOlderstMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
