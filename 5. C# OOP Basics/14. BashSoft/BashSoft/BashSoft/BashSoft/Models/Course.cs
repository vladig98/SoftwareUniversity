using BashSoft.Exceptions;
using System;
using System.Collections.Generic;

namespace BashSoft.Models
{
    public class Course
    {
        //public string name;
        //public Dictionary<string, Student> studentsByName;
        private string name;
        private Dictionary<string, Student> studentsByName;
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoreOnExamTask = 100;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                    //throw new ArgumentNullException(nameof(name), ExceptionMessages.NullOrEmptyValue);
                }
                name = value;
            }
        }

        public IReadOnlyDictionary<string, Student> StudentsByName
        {
            get
            {
                return studentsByName;
            }
        }

        public Course(string name)
        {
            Name = name;
            studentsByName = new Dictionary<string, Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (studentsByName.ContainsKey(student.Username))
            {
                throw new DuplicateEntryInStructureException(student.Username, Name);
               //throw new ArgumentException(string.Format(ExceptionMessages.StudentAlreadyEnrolledInGivenCourse, student.Username, Name));
            }

            studentsByName.Add(student.Username, student);
        }
    }
}
