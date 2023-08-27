using System.IO;

namespace BashSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            //-----------------------
            //IOManager.TraverseDirectory(Directory.GetCurrentDirectory());

            //Test 2
            //-------------------------
            //StudentsRepository.InitializeData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");

            //Test 3
            //------------------------
            //StudentsRepository.InitializeData();
            //StudentsRepository.GetStudentsScoresFromCourse("Unity", "Ivan");

            //Test 4 and 5
            //-----------------------
            //string path = @"";

            //Test 4
            //--------------------------
            //Tester.CompareContent(path + "test1.txt", path + "test2.txt");

            //Test 5
            //--------------------------
            //Tester.CompareContent(path + "test2.txt", path + "test3.txt");

            //Test 6
            //-------------------------
            //IOManager.CreateDirectoryInCurrentFolder("pesho");

            //Test 7
            //-------------------------
            //IOManager.TraverseDirectory(0);

            //Test 8
            //IOManager.ChangeCurrentDirectoryRelative("..\\..\\..");
            //IOManager.TraverseDirectory(0);

            //Test 9
            //IOManager.ChangeCurrentDirectoryAbsolute("..\\..\\..\\obj");
            //IOManager.TraverseDirectory(0);

            //Test 10
            //IOManager.ChangeCurrentDirectoryRelative("..\\..\\..\\obj");
            //IOManager.TraverseDirectory(0);

            //Test 11
            //IOManager.ChangeCurrentDirectoryRelative("..\\..\\..\\pesho");
            //IOManager.TraverseDirectory(0);

            //Test 12
            //IOManager.ChangeCurrentDirectoryAbsolute(@"C:\Windows");
            //IOManager.TraverseDirectory(20);

            //Test 13
            //string path = @"";
            //Tester.CompareContent(path + "actual.txt", path + "expected.txt");

            //Test 14
            //string path = @"";
            //Tester.CompareContent(path + "actual.txt", path + "expected.txt");

            //Test 15
            //IOManager.CreateDirectoryInCurrentFolder("*2");

            //Test 16
            //string path = @"";
            //Tester.CompareContent(path + "actual.txt", path + "expected.txt");

            //Test 17
            //for (int i = 0; i < 20; i++)
            //{
            //    IOManager.ChangeCurrentDirectoryRelative("..");
            //}

            //Test 18, 19, 20
            //InputReader.StartReadingCommands();

            Tester tester = new Tester();
            IOManager iOManager = new IOManager();
            StudentsRepository studentsRepository = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());

            CommandInterpreter currentInterpreter = new CommandInterpreter(tester, studentsRepository, iOManager);
            InputReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}
