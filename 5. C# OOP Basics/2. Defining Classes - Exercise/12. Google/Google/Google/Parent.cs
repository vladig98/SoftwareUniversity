using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Parent
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public Parent(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
    }
}
