using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public decimal Salary { get { return salary; } set { salary = value; } }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public void IncreaseSalary(decimal percentage)
        {
            percentage = Age < 30 ? percentage / 2.0M : percentage;
            percentage = percentage / 100.0M + 1;

            Salary *= percentage; 
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }
    }
}
