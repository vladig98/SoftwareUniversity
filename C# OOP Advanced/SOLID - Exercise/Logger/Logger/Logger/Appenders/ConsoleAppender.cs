using Logger.Layouts;
using System;

namespace Logger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ILayout Layout { get; }
        public ReportLevel _ReportLevel { get; set; }
        public int Messages { get; private set; }

        public ConsoleAppender(ILayout layout)
        {
            Layout = layout;
            Messages = 0;
            _ReportLevel = ReportLevel.info;
        }

        public void Append(string dateTime, string logLevel, string message)
        {
            if (!CanLog(logLevel))
            {
                return;
            }

            Console.WriteLine(string.Format(Layout.Format, dateTime, logLevel, message));
            Messages++;
        }

        private bool CanLog(string logLevel)
        {
            Enum.TryParse(logLevel.ToLower(), out ReportLevel level);
            int index = (int)level;

            return index >= (int)_ReportLevel;
        }
    }
}
