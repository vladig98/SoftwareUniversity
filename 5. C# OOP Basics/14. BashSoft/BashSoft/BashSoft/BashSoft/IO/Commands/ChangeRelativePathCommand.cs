using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    internal class ChangeRelativePathCommand : Command
    {
        public ChangeRelativePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string relPath = Data[1];

                InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
