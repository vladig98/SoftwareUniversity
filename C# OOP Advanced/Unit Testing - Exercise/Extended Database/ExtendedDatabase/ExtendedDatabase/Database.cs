using System;
using System.Linq;

namespace ExtendedDatabase
{
    public class Database
    {
        private Person[] People;

        public Database(params Person[] people)
        {
            People = new Person[16];

            if (people.Length > 16)
            {
                throw new InvalidOperationException("You need to have up to 16 people.");
            }

            for (int i = 0; i < people.Length; i++)
            {
                People[i] = people[i];
            }
        }

        public void Add(Person person)
        {
            for (int i = 0; i < People.Length; i++)
            {
                if (People[i] == null && !People.Where(x => x != null).Any(x => x.Name == person.Name) && 
                    !People.Where(x => x != null).Any(x => x.Id == person.Id))
                {
                    People[i] = person;
                    return;
                }
            }

            throw new InvalidOperationException("This person is already in the database.");
        }

        public void Remove()
        {
            for (int i = People.Length - 1; i >= 0; i--)
            {
                if (People[i] != null)
                {
                    People[i] = null;
                    return;
                }
            }

            throw new InvalidOperationException("The database is empty.");
        }

        public Person[] Fetch()
        {
            return People.ToArray();
        }

        public Person FindByUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentNullException("You should provide a valid username.");
            }

            if (!People.Where(x => x != null).Any(x => x.Name == username))
            {
                throw new InvalidOperationException("No such person exist.");
            }

            return People.Where(x => x != null).FirstOrDefault(x => x.Name == username);
        }

        public Person FindById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("The index should be a positive number.");
            }

            if (!People.Where(x => x != null).Any(x => x.Id == id))
            {
                throw new InvalidOperationException("There are no such people.");
            }

            return People.FirstOrDefault(x => x.Id == id);
        }
    }
}
