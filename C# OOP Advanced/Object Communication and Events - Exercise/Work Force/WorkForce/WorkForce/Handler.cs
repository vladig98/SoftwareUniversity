using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public class Handler
    {
        public void OnJobUpdate(object o, JobUpdateEventArgs e)
        {
            if (e.WorkHours <= 0) 
            {
                Console.WriteLine($"Job {e.JobName} done!");
            }
        }
    }
}
