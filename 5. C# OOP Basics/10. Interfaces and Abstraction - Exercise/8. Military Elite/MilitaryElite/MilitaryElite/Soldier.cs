using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Soldier : ISoldier
    {
        public string id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public Soldier(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return string.Format($"Name: {firstName} {lastName} Id: {id}");
        }
    }
}
