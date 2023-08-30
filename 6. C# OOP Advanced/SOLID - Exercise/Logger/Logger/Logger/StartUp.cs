using Logger.Appenders;
using Logger.Controllers;
using Logger.Layouts;
using Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //test 1
            //ILayout simpleLayout = new SimpleLayout();
            //IAppender consoleAppender =
            //     new ConsoleAppender(simpleLayout);
            //ILogger logger = new Loggers.Logger(consoleAppender);

            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");


            //test2
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);

            //var file = new LogFile();
            //var fileAppender = new FileAppender(simpleLayout);
            //fileAppender.LogFile = file;

            //var logger = new Loggers.Logger(consoleAppender, fileAppender);
            //logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            //logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");


            //test 3
            //var xmlLayout = new XmlLayout();
            //var consoleAppender = new ConsoleAppender(xmlLayout);
            //var logger = new Loggers.Logger(consoleAppender);

            //logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            //logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");


            //test 4
            //var simpleLayout = new SimpleLayout();
            //var consoleAppender = new ConsoleAppender(simpleLayout);
            //consoleAppender._ReportLevel = ReportLevel.error;

            //var logger = new Loggers.Logger(consoleAppender);

            //logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            //logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            //logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            //logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            //logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");

            //Main Program
            int numberOfAppenders = int.Parse(Console.ReadLine());
            MainController controller = new MainController();

            List<IAppender> appenders = new List<IAppender>();

            for (int i = 0; i < numberOfAppenders; i++)
            {
                string[] appenderTokens = Console.ReadLine().Split(" ");

                appenders.Add(controller.CreateAppender(appenderTokens));
            }

            ILogger logger = appenders.Any(x => x is FileAppender) ?
                new Loggers.Logger(appenders.Where(x => x is ConsoleAppender).Last(), appenders.Where(x => x is FileAppender).Last()) :
                new Loggers.Logger(appenders.Where(x => x is ConsoleAppender).Last());

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] reportTokens = input.Split("|");

                controller.PrintMessage(reportTokens, logger);

                input = Console.ReadLine();
            }

            Console.WriteLine(logger);
        }
    }
}
