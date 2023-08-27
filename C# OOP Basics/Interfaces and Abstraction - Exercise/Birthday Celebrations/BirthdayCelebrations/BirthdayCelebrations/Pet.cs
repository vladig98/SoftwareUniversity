using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : ICitizen, INameAble, IBirthDataAble
    {
        public string name { get; private set; }
        public string birthDate { get; private set; }

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }
    }
}
