public class SortingDecorator : ReportDecorator
{
    private string _criteria;

    public SortingDecorator(IReport report, string criteria)
        : base(report)
    {
        _criteria = criteria;
    }

    public override string Generate()
    {
        return _report.Generate() + $"\n[Sorted by: {_criteria}]";
    }
}
