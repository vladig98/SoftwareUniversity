using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;
using System.Collections.Generic;

namespace BashSoft.IO.Commands
{
    [Alias("display")]
    public class DisplayCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public DisplayCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (Data.Length != 3)
            {
                throw new InvalidCommandException(Input);
            }

            string entityToDisplay = Data[1];
            string sortType = Data[2];

            if (entityToDisplay.Equals("students", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<IStudent> studentComparator = CreateStudentComparator(sortType);
                ISimpleOrderedBag<IStudent> list = repository.GetAllStudentsSorted(studentComparator);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine));
            }
            else if (entityToDisplay.Equals("courses", StringComparison.OrdinalIgnoreCase))
            {
                IComparer<ICourse> courseComparator = CreateCourseComparator(sortType);
                ISimpleOrderedBag<ICourse> list = repository.GetAllCoursesSorted(courseComparator);
                OutputWriter.WriteMessageOnNewLine(list.JoinWith(Environment.NewLine));
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }

        private IComparer<ICourse> CreateCourseComparator(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((courseOne, courseTwo) =>
                {
                    //if (courseOne == null && courseTwo == null)
                    //{
                    //    return 0;
                    //}
                    //else if (courseOne == null)
                    //{
                    //    return -1;
                    //}
                    //else if (courseTwo == null)
                    //{
                    //    return 1;
                    //}

                    return courseOne.CompareTo(courseTwo);
                });
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<ICourse>.Create((courseOne, courseTwo) => 
                {
                    //if (courseOne == null && courseTwo == null)
                    //{
                    //    return 0;
                    //}
                    //else if (courseOne == null)
                    //{
                    //    return -1;
                    //}
                    //else if (courseTwo == null)
                    //{
                    //    return 1;
                    //}

                    return courseTwo.CompareTo(courseOne);
                });
            }

            throw new InvalidCommandException(Input);
        }

        private IComparer<IStudent> CreateStudentComparator(string sortType)
        {
            if (sortType.Equals("ascending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) => 
                {
                    //if (studentOne == null && studentTwo == null)
                    //{
                    //    return 0;
                    //}
                    //else if (studentOne == null)
                    //{
                    //    return -1;
                    //}
                    //else if (studentTwo == null)
                    //{
                    //    return 1;
                    //}

                    return studentOne.CompareTo(studentTwo);
                });
            }

            if (sortType.Equals("descending", StringComparison.OrdinalIgnoreCase))
            {
                return Comparer<IStudent>.Create((studentOne, studentTwo) =>
                {
                    //if (studentOne == null && studentTwo == null)
                    //{
                    //    return 0;
                    //}
                    //else if (studentOne == null)
                    //{
                    //    return -1;
                    //}
                    //else if (studentTwo == null)
                    //{
                    //    return 1;
                    //}

                    return studentTwo.CompareTo(studentOne);
                });
            }

            throw new InvalidCommandException(Input);
        }
    }
}
