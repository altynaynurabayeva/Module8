using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Decorator Pattern: Reports ===\n");

        // Базовый отчёт по продажам
        IReport report = new SalesReport();

        // Добавляем фильтр, сортировку и экспорт
        report = new DateFilterDecorator(report, "2025-01-01", "2025-12-31");
        report = new SortingDecorator(report, "Amount");
        report = new CsvExportDecorator(report);

        Console.WriteLine(report.Generate());

        // Отчёт по пользователям
        IReport userReport = new UserReport();
        userReport = new SortingDecorator(userReport, "Status");
        userReport = new PdfExportDecorator(userReport);

        Console.WriteLine("\n" + userReport.Generate());

        Console.WriteLine("\nPress Enter to continue to Adapter example...");
        Console.ReadLine();

        // Вызов второй части (Адаптер)
        AdapterDemo.Run();
    }
}
