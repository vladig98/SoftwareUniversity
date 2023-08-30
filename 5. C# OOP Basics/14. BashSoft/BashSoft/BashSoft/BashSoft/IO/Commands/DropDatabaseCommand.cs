using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    internal class DropDatabaseCommand : Command
    {
        public DropDatabaseCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length != 1)
            {
                throw new InvalidCommandException(Input);
            }

            Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
