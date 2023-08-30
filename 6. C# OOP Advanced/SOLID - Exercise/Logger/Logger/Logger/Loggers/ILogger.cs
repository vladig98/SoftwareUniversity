using Logger.Appenders;

namespace Logger.Loggers
{
    public interface ILogger
    {
        IAppender ConsoleAppender { get; }
        IAppender FileAppender { get; }

        void Error(string dateTime, string message);
        void Info(string dateTime, string message);
        void Warn(string dateTime, string message);
        void Fatal(string dateTime, string message);
        void Critical(string dateTime, string message);
    }
}
