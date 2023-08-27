using Logger.Appenders;
using Logger.Layouts;
using Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Controllers
{
    public class MainController
    {
        public IAppender CreateAppender(string[] appenderTokens)
        {
            string appenderType = appenderTokens[0];
            string layoutType = appenderTokens[1];
            string reportLevel = appenderTokens.Length > 2 ? appenderTokens[2] : "";

            ILayout layout = null;
            IAppender appender = null;

            if (layoutType.ToLower() == "simplelayout")
            {
                layout = new SimpleLayout();
            }
            else if (layoutType.ToLower() == "xmllayout")
            {
                layout = new XmlLayout();
            }

            if (appenderType.ToLower() == "consoleappender")
            {
                appender = new ConsoleAppender(layout);
            }
            else if (appenderType.ToLower() == "fileappender")
            {
                appender = new FileAppender(layout);
            }

            if (!string.IsNullOrWhiteSpace(reportLevel) && !string.IsNullOrEmpty(reportLevel))
            {
                Enum.TryParse(reportLevel.ToLower(), out ReportLevel level);
                appender._ReportLevel = level;
            }

            return appender;
        }

        public void PrintMessage(string[] reportTokens, ILogger logger)
        {
            string reportLevel = reportTokens[0];
            string time = reportTokens[1];
            string message = reportTokens[2];

            switch (reportLevel.ToLower())
            {
                case "info":
                    logger.Info(time, message);
                    break;
                case "warning":
                    logger.Warn(time, message);
                    break;
                case "error":
                    logger.Error(time, message);
                    break;
                case "critical":
                    logger.Critical(time, message);
                    break;
                case "fatal":
                    logger.Fatal(time, message);
                    break;
                default:
                    break;
            }
        }
    }
}
