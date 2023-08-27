using BashSoft.Exceptions;
using System.Diagnostics;

namespace BashSoft.IO.Commands
{
    public class OpenFileCommand : Command
    {
        public OpenFileCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            :base(input, data, judge, repository, inputOutputManager)
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
