using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    internal class ReadDatabaseCommand : Command
    {
        public ReadDatabaseCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string fileName = Data[1];

                Repository.LoadData(fileName);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
