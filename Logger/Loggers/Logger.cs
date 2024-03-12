using SoftUniLogger.Appenders;
using SoftUniLogger.Enums;
using System.Linq;

namespace SoftUniLogger.Loggers;

public class Logger : ILogger
{
    private readonly IAppender[] appenders;

    public Logger(params IAppender[] appenders)
    {
        this.appenders = appenders;
    }

    public void Critical(string date, string message)
    {
        AppendToAppenders(date, ReportLevel.Critical, message);
    }

    public void Error(string date, string message)
    {
        AppendToAppenders(date, ReportLevel.Error, message);
    }

    public void Fatal(string date, string message)
    {
        AppendToAppenders(date, ReportLevel.Fatal, message);
    }

    public void Info(string date, string message)
    {
        AppendToAppenders(date, ReportLevel.Info, message);
    }

    public void Warning(string date, string message)
    {
        AppendToAppenders(date, ReportLevel.Warning, message);
    }

    private void AppendToAppenders(string date, ReportLevel reportLevel, string message)
    {
        foreach (var appender in appenders)
        {
            appender.Append(date, reportLevel, message);
        }
    }
}
