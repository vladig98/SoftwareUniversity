using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public string Name { get; }
        public int Age { get; }
        string IPerson.GetName()
        {
            return Name;
        }

        public string Country { get; }

        string IResident.GetName()
        {
            return string.Format($"Mr/Ms/Mrs {Name}");
        }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Age = age;
            Country = country;
        }
    }
}
