using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public class StandardEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkHoursPerWeek { get => 40; }

        public StandardEmployee(string name)
        {
            Name = name;
        }
    }
}
