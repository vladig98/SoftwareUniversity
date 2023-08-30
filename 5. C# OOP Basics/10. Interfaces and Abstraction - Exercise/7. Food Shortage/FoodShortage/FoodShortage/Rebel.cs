using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : ICitizen, INameAble, IAgeAble, IBuyer
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string group { get; private set; }
        public int food { get; private set; }

        public void BuyFood()
        {
            food += 5;
        }

        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            food = 0;
        }
    }
}
