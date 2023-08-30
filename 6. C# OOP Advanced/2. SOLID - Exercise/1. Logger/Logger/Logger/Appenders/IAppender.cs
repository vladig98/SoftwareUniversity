using Logger.Layouts;

namespace Logger.Appenders
{
    public interface IAppender
    {
        ILayout Layout { get; }
        void Append(string dateTime, string logLevel, string message);
        ReportLevel _ReportLevel { get; set; }
        int Messages { get; }
    }
}
