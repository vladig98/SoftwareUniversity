using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    public class PrintOrderedStudentsCommand : Command
    {
        public PrintOrderedStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (Data.Length == 5)
            {
                string courseName = Data[1];
                string filter = Data[2].ToLower();
                string takeCommand = Data[3].ToLower();
                string takeQuantity = Data[4].ToLower();

                TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, filter);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }

        private void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string comparator)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    Repository.OrderAndTake(courseName, comparator);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

                    if (hasParsed)
                    {
                        Repository.OrderAndTake(courseName, comparator, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
            }
        }
    }
}
