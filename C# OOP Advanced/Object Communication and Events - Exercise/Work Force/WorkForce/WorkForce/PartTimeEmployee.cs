using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public int WorkHoursPerWeek { get => 20; }

        public PartTimeEmployee(string name)
        {
            Name = name;
        }
    }
}
