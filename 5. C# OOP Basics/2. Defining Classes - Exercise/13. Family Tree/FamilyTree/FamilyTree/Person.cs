using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
    public class Person
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public List<Person> Parents { get; set; }
        public List<Person> Children { get; set; }

        public Person(string name)
        {
            if (name.Contains("/"))
            {
                BirthDate = name;
            }
            else
            {
                Name = name;
            }
            Parents = new List<Person>();
            Children = new List<Person>();
        }
    }
}
