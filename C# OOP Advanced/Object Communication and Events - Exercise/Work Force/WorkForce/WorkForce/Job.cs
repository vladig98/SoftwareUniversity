using System;
using System.Collections.Generic;
using System.Text;

namespace WorkForce
{
    public delegate void JobUpdateEventHandler(Job j, JobUpdateEventArgs e);

    public class Job
    {
        public string Name { get; set; }
        public int HoursOfWorkRequired { get; set; }

        private IEmployee Employee;

        private Handler handler;
        public event JobUpdateEventHandler JobUpdate;

        public Job(Handler handler, IEmployee employee, string name, int hours)
        {
            this.handler = handler; 
            Employee = employee;
            Name = name;
            HoursOfWorkRequired = hours;
        }

        public void Update()
        {
            HoursOfWorkRequired -= Employee.WorkHoursPerWeek;
            OnUpdate(new JobUpdateEventArgs(Name, HoursOfWorkRequired));
        }

        public void OnUpdate(JobUpdateEventArgs e)
        {
            handler.OnJobUpdate(this, e);
        }

        public override string ToString()
        {
            return $"Job: {Name} Hours Remaining: {HoursOfWorkRequired}";
        }
    }
}
