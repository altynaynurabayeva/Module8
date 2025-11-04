using System;

public class DateFilterDecorator : ReportDecorator
{
    private string _startDate;
    private string _endDate;

    public DateFilterDecorator(IReport report, string startDate, string endDate)
        : base(report)
    {
        _startDate = startDate;
        _endDate = endDate;
    }

    public override string Generate()
    {
        return _report.Generate() + $"\n[Filtered by date: {_startDate} - {_endDate}]";
    }
}
