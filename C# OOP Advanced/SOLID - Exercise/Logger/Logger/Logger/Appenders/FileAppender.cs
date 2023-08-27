using Logger.Layouts;
using Logger.Loggers;
using System;
using System.IO;

namespace Logger.Appenders
{
    public class FileAppender : IAppender
    {
        public ILayout Layout { get; }
        public LogFile LogFile { get; set; }
        public ReportLevel _ReportLevel { get; set; }
        public int Messages { get; private set; }

        public FileAppender(ILayout layout)
        {
            Layout = layout;
            Messages = 0;
            _ReportLevel = ReportLevel.info;
            LogFile = new LogFile();
        }

        public void Append(string dateTime, string logLevel, string message)
        {
            if (!CanLog(logLevel))
            {
                return;
            }

            string output = string.Format(Layout.Format, dateTime, logLevel, message);

            File.AppendAllText("../../../log.txt", output + Environment.NewLine);
            Messages++;
            LogFile.Write(output);
        }

        private bool CanLog(string logLevel)
        {
            Enum.TryParse(logLevel.ToLower(), out ReportLevel level);
            int index = (int)level;

            return index >= (int)_ReportLevel;
        }
    }
}
