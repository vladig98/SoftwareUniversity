using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public interface IEmployee
    {
        string Name { get; }
        int WorkHoursPerWeek { get; }
    }
}
