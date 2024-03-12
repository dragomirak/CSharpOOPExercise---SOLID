using SoftUniLogger.Enums;

namespace SoftUniLogger.Appenders;

public interface IAppender
{
    ReportLevel ReportLevel { get; set; }
    void Append(string date, ReportLevel reportLevel, string message);
}
