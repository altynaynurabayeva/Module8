public class PdfExportDecorator : ReportDecorator
{
    public PdfExportDecorator(IReport report) : base(report) { }

    public override string Generate()
    {
        return _report.Generate() + "\n[Exported as PDF]";
    }
}
