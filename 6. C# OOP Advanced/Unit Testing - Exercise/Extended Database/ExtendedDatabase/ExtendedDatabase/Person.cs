using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ExtendedDatabase
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
