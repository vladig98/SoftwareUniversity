using System;

namespace ExtendedDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person((i + 1), $"Pesho{(i + 1)}");
            }

            Database FullPeople = new Database(people);

            FullPeople.Remove();

            var result = FullPeople.Fetch();
        }
    }
}
