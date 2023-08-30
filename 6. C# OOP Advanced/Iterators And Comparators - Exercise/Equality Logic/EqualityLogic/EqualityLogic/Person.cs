using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Person p = obj as Person;
            if ((System.Object)p == null)
                return false;

            return (Name == p.Name) && (Age == p.Age);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }

        public int CompareTo([AllowNull] Person other)
        {
            var result = Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }

            return result;
        }
    }
}
