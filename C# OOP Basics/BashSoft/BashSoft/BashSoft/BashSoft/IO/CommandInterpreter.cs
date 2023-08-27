using BashSoft.Exceptions;
using BashSoft.IO.Commands;
using System;

namespace BashSoft
{
    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        public CommandInterpreter(Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpredCommand(string input)
        {
            string[] data = input.Split(" ");
            string commandName = data[0];
            commandName = commandName.ToLower();

            try
            {
                Command command = ParseCommand(input, commandName, data);
                command.Execute();
            }
            //catch (DirectoryNotFoundException dnfe)
            //{
            //    OutputWriter.DisplayException(dnfe.Message);
            //}
            //catch (ArgumentOutOfRangeException aoore)
            //{
            //    OutputWriter.DisplayException(aoore.Message);
            //}
            //catch (ArgumentException ae)
            //{
            //    OutputWriter.DisplayException(ae.Message);
            //}
            //catch (FileNotFoundException fnfe)
            //{
            //    OutputWriter.DisplayException(fnfe.Message);
            //}
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message); 
            }
        }

        private Command ParseCommand(string input, string command, string[] data)
        {
            switch (command)
            {
                case "open":
                    return new OpenFileCommand(input, data, judge, repository, inputOutputManager);
                case "mkdir":
                    return new MakeDirectoryCommand(input, data, judge, repository, inputOutputManager);
                case "ls":
                    return new TraverseFoldersCommand(input, data, judge, repository, inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, judge, repository, inputOutputManager);
                case "cdRel":
                    return new ChangeRelativePathCommand(input, data, judge, repository, inputOutputManager);
                case "cdAbs":
                    return new ChangeAbsolutePathCommand(input, data, judge, repository, inputOutputManager);
                case "readDb":
                    return new ReadDatabaseCommand(input, data, judge, repository, inputOutputManager);
                case "help":
                    return new GetHelpCommand(input, data, judge, repository, inputOutputManager);
                case "show":
                    return new ShowCourseCommand(input, data, judge, repository, inputOutputManager);
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, judge, repository, inputOutputManager);
                case "order":
                    return new PrintOrderedStudentsCommand(input, data, judge, repository, inputOutputManager);
                case "decOrder":
                    break;
                case "download":
                    break;
                case "downloadAsync":
                    break;
                case "dropdb":
                    return new DropDatabaseCommand(input, data, judge, repository, inputOutputManager);
                default:
                    throw new InvalidCommandException(input);
            }

            return null;
        }

        //private void TryDropDb(string input, string[] data)
        //{
        //    if (data.Length != 1)
        //    {
        //        DisplayInvalidCommandMessage(input);
        //        return;
        //    }

        //    repository.UnloadData();
        //    OutputWriter.WriteMessageOnNewLine("Database dropped!");
        //}

        //private void TryOrderAndTake(string input, string[] data)
        //{
        //    if (data.Length == 5)
        //    {
        //        string courseName = data[1];
        //        string filter = data[2].ToLower();
        //        string takeCommand = data[3].ToLower();
        //        string takeQuantity = data[4].ToLower();

        //        TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, filter);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string comparator)
        //{
        //    if (takeCommand == "take")
        //    {
        //        if (takeQuantity == "all")
        //        {
        //            repository.OrderAndTake(courseName, comparator);
        //        }
        //        else
        //        {
        //            int studentsToTake;
        //            bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

        //            if (hasParsed)
        //            {
        //                repository.OrderAndTake(courseName, comparator, studentsToTake);
        //            }
        //            else
        //            {
        //                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
        //    }
        //}

        //private void TryFilterAndTake(string input, string[] data)
        //{
        //    if (data.Length == 5)
        //    {
        //        string courseName = data[1];
        //        string filter = data[2].ToLower();
        //        string takeCommand = data[3].ToLower();
        //        string takeQuantity = data[4].ToLower();

        //        TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        //{
        //    if (takeCommand == "take")
        //    {
        //        if (takeQuantity == "all")
        //        {
        //            repository.FilterAndTake(courseName, filter);
        //        }
        //        else
        //        {
        //            int studentsToTake;
        //            bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);

        //            if (hasParsed)
        //            {
        //                repository.FilterAndTake(courseName, filter, studentsToTake);
        //            }
        //            else
        //            {
        //                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
        //    }
        //}

        //private void TryShowWantedData(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string courseName = data[1];
        //        repository.GetAllStudentsFromCourse(courseName);
        //    }
        //    else if (data.Length == 3)
        //    {
        //        string courseName = data[1];
        //        string userName = data[2];
        //        repository.GetStudentsScoresFromCourse(courseName, userName);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryGetHelp(string input, string[] data)
        //{
        //    if (data.Length == 1)
        //    {
        //        OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "make directory - mkdir: path "));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "traverse directory - ls: depth "));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "comparing files - cmp: path1 path2"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "change directory - changeDirREl:relative path"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "change directory - changeDir:absolute path"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "read students data base - readDb: path"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "download file - download: path of file (saved in current directory)"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "download file asinchronously - downloadAsynch: path of file (save in the current directory)"));
        //        OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "get help – help"));
        //        OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
        //        OutputWriter.WriteEmptyLine();
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryReadDataBaseFromFile(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string fileName = data[1];

        //        repository.LoadData(fileName);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryChangePathAbsolute(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string absolutePath = data[1];

        //        inputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryChangePathRelatively(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string relPath = data[1];

        //        inputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryCompareFiles(string input, string[] data)
        //{
        //    if (data.Length == 3)
        //    {
        //        string firstPath = data[1];
        //        string secondPath = data[2];

        //        judge.CompareContent(firstPath, secondPath);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryTraverseFolders(string input, string[] data)
        //{
        //    if (data.Length == 1)
        //    {
        //        inputOutputManager.TraverseDirectory(0);
        //    }
        //    else if (data.Length == 2)
        //    {
        //        int depth;
        //        bool hasParsed = int.TryParse(data[1], out depth);

        //        if (hasParsed)
        //        {
        //            inputOutputManager.TraverseDirectory(depth);
        //        }
        //        else
        //        {
        //            OutputWriter.DisplayException(ExceptionMessages.UnableToParseNumber);
        //        }
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryCreateDirectory(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string folderName = data[1];
        //        inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void TryOpenFile(string input, string[] data)
        //{
        //    if (data.Length == 2)
        //    {
        //        string fileName = data[1];
        //        Process.Start(SessionData.currentPath + "\\" + fileName);
        //    }
        //    else
        //    {
        //        DisplayInvalidCommandMessage(input);
        //    }
        //}

        //private void DisplayInvalidCommandMessage(string input)
        //{
        //    throw new InvalidCommandException(input);
        //    //OutputWriter.DisplayException(string.Format(ExceptionMessages.InvalidCommand, input));
        //}
    }
}
