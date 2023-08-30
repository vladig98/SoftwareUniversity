using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("cdAbs")]
    internal class ChangeAbsolutePathCommand : Command
    {
        [Inject]
        private IDirectoryManager inputOutputManager;

        public ChangeAbsolutePathCommand(string input, string[] data)
            : base(input, data)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string absolutePath = Data[1];

                inputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
