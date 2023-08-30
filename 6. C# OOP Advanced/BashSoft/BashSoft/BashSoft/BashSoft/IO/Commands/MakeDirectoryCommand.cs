using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("mkdir")]
    public class MakeDirectoryCommand : Command
    {
        [Inject]
        private IDirectoryManager inputOutputManager;

        public MakeDirectoryCommand(string input, string[] data)
            : base(input, data)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string folderName = Data[1];
                inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
