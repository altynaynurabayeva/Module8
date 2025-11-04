using System;

public class SalesReport : IReport
{
    public string Generate()
    {
        return "Sales Report:\n- Order #1: $120\n- Order #2: $80\n- Order #3: $50\n";
    }
}
