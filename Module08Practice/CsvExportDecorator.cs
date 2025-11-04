public class CsvExportDecorator : ReportDecorator
{
    public CsvExportDecorator(IReport report) : base(report) { }

    public override string Generate()
    {
        return _report.Generate() + "\n[Exported as CSV]";
    }
}
