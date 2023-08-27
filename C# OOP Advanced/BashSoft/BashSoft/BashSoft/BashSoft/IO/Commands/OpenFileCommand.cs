using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System.Diagnostics;

namespace BashSoft.IO.Commands
{
    [Alias("open")]
    public class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data)
            : base(input, data)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 2)
            {
                string fileName = Data[1];
                Process.Start(SessionData.currentPath + "\\" + fileName);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }
    }
}
