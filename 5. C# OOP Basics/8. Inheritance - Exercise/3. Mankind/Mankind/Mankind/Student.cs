using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                if (!Regex.IsMatch(value,@"^[a-zA-Z0-9]+$"))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"Faculty number: {FacultyNumber}");
        }

        public Student(string firstName, string lastName, string facultyNumber):base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;
        }
    }
}
