using SoftUniLogger.Enums;
using SoftUniLogger.Layouts;

namespace SoftUniLogger.Appenders;

public class ConsoleAppender : Appender
{
    public ConsoleAppender(ILayout layout) : base(layout)
    {
    }

    public override void Append(string date, ReportLevel reportLevel, string message)
    {
        if (CanAppend(reportLevel))
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message);
            Console.WriteLine(content);
        }
        
    }
}
