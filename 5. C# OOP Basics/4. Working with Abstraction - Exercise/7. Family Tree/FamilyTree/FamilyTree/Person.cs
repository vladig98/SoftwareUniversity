using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        public Person()
        {
            Children = new List<Person>();
            Parents = new List<Person>();
        }

        public override string ToString()
        {
            return $"{Name} {BirthDay}";
        }
    }
}
