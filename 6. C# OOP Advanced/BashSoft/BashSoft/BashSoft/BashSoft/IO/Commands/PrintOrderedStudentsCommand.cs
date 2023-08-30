using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("order")]
    public class PrintOrderedStudentsCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public PrintOrderedStudentsCommand(string input, string[] data)
            : base(input, data)
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
                    repository.OrderAndTake(courseName, comparator);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

                    if (hasParsed)
                    {
                        repository.OrderAndTake(courseName, comparator, studentsToTake);
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
