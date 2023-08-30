using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("show")]
    internal class ShowCourseCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public ShowCourseCommand(string input, string[] data)
            : base(input, data)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string courseName = Data[1];
                repository.GetStudentsByCourse(courseName);
            }
            else if (Data.Length == 3)
            {
                string courseName = Data[1];
                string userName = Data[2];
                repository.GetStudentsMarkInCourse(courseName, userName);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
