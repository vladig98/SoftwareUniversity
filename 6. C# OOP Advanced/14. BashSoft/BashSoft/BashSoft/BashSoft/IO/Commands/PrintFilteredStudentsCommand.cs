﻿using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using System;

namespace BashSoft.IO.Commands
{
    [Alias("filter")]
    internal class PrintFilteredStudentsCommand : Command
    {
        [Inject]
        private IDatabase repository;

        public PrintFilteredStudentsCommand(string input, string[] data)
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

                TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
            }
            else
            {
                throw new InvalidCommandException(Input);
            }
        }

        private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    repository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

                    if (hasParsed)
                    {
                        repository.FilterAndTake(courseName, filter, studentsToTake);
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
