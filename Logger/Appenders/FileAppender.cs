using SoftUniLogger.Enums;
using SoftUniLogger.Layouts;
using SoftUniLogger.Loggers;

namespace SoftUniLogger.Appenders;

public class FileAppender : Appender
{
    private ILogFile logFile;
    public FileAppender(ILayout layout, ILogFile logFile) : base(layout)
    {
        this.logFile = logFile;
    }

    public override void Append(string date, ReportLevel reportLevel, string message)
    {
        if (CanAppend(reportLevel))
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message) + Environment.NewLine;
            logFile.Write(content);
        }

        
    }
}
