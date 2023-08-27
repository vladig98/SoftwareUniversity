using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("cmp")]
    internal class CompareFilesCommand : Command
    {
        [Inject]
        private IContentComparer judge;

        public CompareFilesCommand(string input, string[] data)
            : base(input, data)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 3)
            {
                string firstPath = Data[1];
                string secondPath = Data[2];

                judge.CompareContent(firstPath, secondPath);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
