using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    internal class ChangeAbsolutePathCommand : Command
    {
        public ChangeAbsolutePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string absolutePath = Data[1];

                InputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
