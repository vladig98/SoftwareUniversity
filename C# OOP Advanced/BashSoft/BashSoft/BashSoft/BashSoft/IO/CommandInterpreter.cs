using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;
using BashSoft.IO.Commands;
using System;
using System.Linq;
using System.Reflection;

namespace BashSoft
{
    public class CommandInterpreter : IInterpreter
    {
        private IContentComparer judge;
        private IDatabase repository;
        private IDirectoryManager inputOutputManager;

        public CommandInterpreter(IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split(" ");
            string commandName = data[0];//.ToLower();

            try
            {
                IExecutable command = ParseCommand(input, commandName, data);
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

        private IExecutable ParseCommand(string input, string command, string[] data)
        {
            object[] parametersForConstruction = new object[] { input, data };

            Type typeOfCommand = Assembly.GetExecutingAssembly().GetTypes().First(t => t.GetCustomAttributes(typeof(AliasAttribute))
            .Where(x => x.Equals(command)).ToArray().Length > 0);

            Type typeOfInterpreter = typeof(CommandInterpreter);

            Command exe = (Command)Activator.CreateInstance(typeOfCommand, parametersForConstruction);

            FieldInfo[] fieldsOfCommand = typeOfCommand.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] fieldsOfInterpreter = typeOfInterpreter.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fieldInfo in fieldsOfCommand)
            {
                Attribute atr = fieldInfo.GetCustomAttribute(typeof(InjectAttribute));

                if (atr != null)
                {
                    if (fieldsOfInterpreter.Any(x => x.FieldType == fieldInfo.FieldType))
                    {
                        fieldInfo.SetValue(exe, fieldsOfInterpreter.First(x => x.FieldType == fieldInfo.FieldType).GetValue(this));
                    }
                }
            }

            return exe;
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
