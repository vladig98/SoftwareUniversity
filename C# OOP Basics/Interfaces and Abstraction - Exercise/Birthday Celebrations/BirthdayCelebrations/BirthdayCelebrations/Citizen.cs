using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : ICitizen, INameAble, IIdAble, IBirthDataAble
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string id { get; private set; }
        public string birthDate { get; private set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthDate = birthDate;
        }
    }
}
