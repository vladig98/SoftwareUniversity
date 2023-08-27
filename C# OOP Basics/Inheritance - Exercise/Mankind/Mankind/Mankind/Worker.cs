using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private double weekSalary;

        public double WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                weekSalary = value;
            }
        }

        private double workHoursPerDay;

        public double WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"Week Salary: {WeekSalary:F2}{Environment.NewLine}" +
                                                   $"Hours per day: {WorkHoursPerDay:F2}{Environment.NewLine}" +
                                                   $"Salary per hour: {CalculateSalaryPerHour():F2}");
        }

        private double CalculateSalaryPerHour()
        {
            return WeekSalary / WorkHoursPerDay / 5.0;
        }

        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay):base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = hoursPerDay;
        }
    }
}
