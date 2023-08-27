using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public class JobUpdateEventArgs : EventArgs
    {
        public string JobName;
        public int WorkHours;

        public JobUpdateEventArgs(string jobName, int workHours)
        {
            JobName = jobName;
            WorkHours = workHours;
        }
    }
}
