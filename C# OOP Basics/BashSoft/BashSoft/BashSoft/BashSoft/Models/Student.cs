using BashSoft.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BashSoft.Models
{
    public class Student
    {
        //public string userName;
        //public Dictionary<string, Course> enrolledCourses;
        //public Dictionary<string, double> marksByCourseName;
        private string userName;
        private Dictionary<string, Course> enrolledCourses;
        private Dictionary<string, double> marksByCourseName;

        public string Username
        {
            get
            {
                return userName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                    //throw new ArgumentNullException(nameof(userName), ExceptionMessages.NullOrEmptyValue);
                }
                userName = value;
            }
        }

        public IReadOnlyDictionary<string, Course> EnrolledCourses
        {
            get
            {
                return enrolledCourses;
            }
        }

        public IReadOnlyDictionary<string, double> MarksByCourseName
        {
            get
            {
                return marksByCourseName;
            }
        }

        public Student(string userName)
        {
            Username = userName;
            enrolledCourses = new Dictionary<string, Course>();
            marksByCourseName = new Dictionary<string, double>();
        }

        public void EnrollInCourse(Course course)
        {
            if (enrolledCourses.ContainsKey(course.Name))
            {
                throw new DuplicateEntryInStructureException(userName, course.Name);
                //throw new ArgumentException(string.Format(ExceptionMessages.StudentAlreadyEnrolledInGivenCourse, userName, course.Name));
                //return;
            }

            enrolledCourses.Add(course.Name, course);
        }

        public void SetMarkOnCourse(string courseName, params int[] scores)
        {
            if (!enrolledCourses.ContainsKey(courseName))
            {
                throw new CourseNotFoundException();
                //throw new KeyNotFoundException(ExceptionMessages.NotEnrolledInCourse);
                //OutputWriter.DisplayException(ExceptionMessages.NotEnrolledInCourse);
                //return;
            }

            if (scores.Length > Course.NumberOfTasksOnExam)
            {
                throw new IndexOutOfRangeException(ExceptionMessages.InvalidNumberOfScores);
                //return;
            }

            marksByCourseName.Add(courseName, CalculateMark(scores));
        }

        private double CalculateMark(int[] scores)
        {
            double percentageOfSolvedExam = scores.Sum() / (double)(Course.NumberOfTasksOnExam * Course.MaxScoreOnExamTask);
            double mark = percentageOfSolvedExam * 4 + 2;
            return mark;
        }
    }
}
