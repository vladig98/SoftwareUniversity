using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    internal class CompareFilesCommand : Command
    {
        public CompareFilesCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 3)
            {
                string firstPath = Data[1];
                string secondPath = Data[2];

                Judge.CompareContent(firstPath, secondPath);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
