using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldestFamilyMember
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public Family()
        {
            people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOlderstMember()
        {
            return People.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
