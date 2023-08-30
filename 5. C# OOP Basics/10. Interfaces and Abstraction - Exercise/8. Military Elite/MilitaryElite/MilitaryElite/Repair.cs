using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public string partName { get; private set; }
        public int hoursWorked { get; private set; }

        public Repair(string partName, int hoursWorked)
        {
            this.partName = partName;
            this.hoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return string.Format($"Part Name: {partName} Hours Worked: {hoursWorked}");
        }
    }
}
