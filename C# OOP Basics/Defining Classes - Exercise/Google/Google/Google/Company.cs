using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Company(string companyName, string department, double salary)
        {
            CompanyName = companyName;
            Department = department;
            Salary = salary;
        }
    }
}
