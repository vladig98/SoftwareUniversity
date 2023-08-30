using System;
using System.Collections.Generic;
using System.Text;

namespace PetClinic
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }

        public Pet(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Kind}";
        }
    }
}
