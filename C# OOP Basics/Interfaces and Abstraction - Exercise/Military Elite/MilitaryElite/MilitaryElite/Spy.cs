using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int spyCode) : base(id, firstName, lastName)
        {
            this.spyCode = spyCode;
        }

        public int spyCode { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{Environment.NewLine}Code Number: {spyCode}");
        }
    }
}
