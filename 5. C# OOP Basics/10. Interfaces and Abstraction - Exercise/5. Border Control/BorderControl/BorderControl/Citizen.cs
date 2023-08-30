using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : ICitizen
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string id { get; private set; }

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
    }
}
