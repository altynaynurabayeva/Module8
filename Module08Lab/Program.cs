using System;

class Program
{
    static void Main(string[] args)
    {
        // === Декоратор ===
        Console.WriteLine("=== Decorator Pattern: Beverages ===\n");

        // Базовый напиток — кофе
        IBeverage beverage = new Coffee();
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        // Добавляем молоко
        beverage = new MilkDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        // Добавляем сахар
        beverage = new SugarDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        // Добавляем шоколад
        beverage = new ChocolateDecorator(beverage);
        Console.WriteLine($"{beverage.GetDescription()} : {beverage.GetCost()}");

        // === Адаптер ===
        Console.WriteLine("\n=== Adapter Pattern: Payments ===\n");

        // Внутренняя система
        IPaymentProcessor internalProcessor = new InternalPaymentProcessor();
        internalProcessor.ProcessPayment(100.0);
        internalProcessor.RefundPayment(50.0);

        // Внешняя система A
        ExternalPaymentSystemA externalA = new ExternalPaymentSystemA();
        IPaymentProcessor adapterA = new PaymentAdapterA(externalA);
        adapterA.ProcessPayment(200.0);
        adapterA.RefundPayment(100.0);

        // Внешняя система B
        ExternalPaymentSystemB externalB = new ExternalPaymentSystemB();
        IPaymentProcessor adapterB = new PaymentAdapterB(externalB);
        adapterB.ProcessPayment(300.0);
        adapterB.RefundPayment(150.0);

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
