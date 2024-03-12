using SoftUniLogger.Enums;
using SoftUniLogger.Layouts;

namespace SoftUniLogger.Appenders;

public abstract class Appender : IAppender
{
    protected ILayout layout;

    protected Appender(ILayout layout)
    {
        this.layout = layout;
    }

    public ReportLevel ReportLevel { get; set; }

    public abstract void Append(string date, ReportLevel reportLevel, string message);
    protected bool CanAppend(ReportLevel reportLevel)
    {
        return reportLevel >= ReportLevel;
    }
    
}
