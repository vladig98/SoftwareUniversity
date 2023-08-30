using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind
{
    public class Human
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                if (!Regex.IsMatch(value[0].ToString(), @"[A-Z]+"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                if (!Regex.IsMatch(value[0].ToString(), @"[A-Z]+"))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"First Name: {FirstName}{Environment.NewLine}Last Name: {LastName}{Environment.NewLine}");
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
