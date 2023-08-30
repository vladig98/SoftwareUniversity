using Logger.Appenders;
using System;
using System.Text;

namespace Logger.Loggers
{
    public class Logger : ILogger
    {
        public IAppender ConsoleAppender { get; }

        public IAppender FileAppender { get; }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            ConsoleAppender = consoleAppender;
            FileAppender = fileAppender;
        }

        public Logger(IAppender consoleAppender)
        {
            ConsoleAppender = consoleAppender;
        }

        private void ConsoleAppend(string dateTime, string logLevel, string message)
        {
            if (ConsoleAppender != null)
            {
                ConsoleAppender.Append(dateTime, logLevel, message);
            }
        }

        private void FileAppend(string dateTime, string logLevel, string message)
        {
            if (FileAppender != null)
            {
                FileAppender.Append(dateTime, logLevel, message);
            }
        }

        public void Error(string dateTime, string message)
        {
            //using reflection
            var logLevel = System.Reflection.MethodBase.GetCurrentMethod().Name;

            //hard-coding it
            //var logLevel = "Error";

            ConsoleAppend(dateTime, logLevel, message);
            FileAppend(dateTime, logLevel, message);
        }

        public void Info(string dateTime, string message)
        {
            //using reflection
            var logLevel = System.Reflection.MethodBase.GetCurrentMethod().Name;

            //hard-coding it
            //var logLevel = "Info";

            ConsoleAppend(dateTime, logLevel, message);
            FileAppend(dateTime, logLevel, message);
        }

        public void Warn(string dateTime, string message)
        {
            //using reflection
            var logLevel = System.Reflection.MethodBase.GetCurrentMethod().Name + "ing";

            //hard-coding it
            //var logLevel = "Warning";

            ConsoleAppend(dateTime, logLevel, message);
            FileAppend(dateTime, logLevel, message);
        }

        public void Critical(string dateTime, string message)
        {
            //using reflection
            var logLevel = System.Reflection.MethodBase.GetCurrentMethod().Name;

            //hard-coding it
            //var logLevel = "Critical";

            ConsoleAppend(dateTime, logLevel, message);
            FileAppend(dateTime, logLevel, message);
        }

        public void Fatal(string dateTime, string message)
        {
            //using reflection
            var logLevel = System.Reflection.MethodBase.GetCurrentMethod().Name;

            //hard-coding it
            //var logLevel = "Fatal";

            ConsoleAppend(dateTime, logLevel, message);
            FileAppend(dateTime, logLevel, message);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"Logger info" + Environment.NewLine);

            stringBuilder.Append($"Appender type: {ConsoleAppender.GetType().Name}, Layout type: {ConsoleAppender.Layout.GetType().Name}, ");

            stringBuilder.Append($"Report Level: {ConsoleAppender._ReportLevel.ToString().ToUpper()}, ");

            stringBuilder.Append($"Messages appended: {ConsoleAppender.Messages}");

            if (FileAppender != null)
            {
                stringBuilder.Append($"{Environment.NewLine}Appender type: {FileAppender.GetType().Name}, Layout type: {FileAppender.Layout.GetType().Name}, ");

                stringBuilder.Append($"Report Level: {FileAppender._ReportLevel.ToString().ToUpper()}, ");

                stringBuilder.Append($"Messages appended: {FileAppender.Messages}, File size: {((FileAppender)FileAppender).LogFile.Size}");
            }

            return stringBuilder.ToString();
        }
    }
}
