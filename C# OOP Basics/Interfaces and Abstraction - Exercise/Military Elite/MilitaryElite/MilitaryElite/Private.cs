using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public double salary { get; private set; }

        public Private(string id, string firstName, string lastName, double salary):base(id, firstName, lastName)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($" Salary: {salary:F2}");
        }
    }
}
