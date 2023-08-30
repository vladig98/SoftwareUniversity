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

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    firstName = value;
                }
                else
                {
                    PrintErrorMessage("First name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    lastName = value;
                }
                else
                {
                    PrintErrorMessage("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    PrintErrorMessage("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 460.0M)
                {
                    salary = value;
                }
                else
                {
                    PrintErrorMessage("Salary cannot be less than 460 leva!");
                }
            }
        }

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

        private void PrintErrorMessage(string message)
        {
            throw new ArgumentException(message);
        }
    }
}
