using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Decorator Pattern: Beverages ===\n");

        Beverage beverage1 = new Espresso();
        beverage1 = new Milk(beverage1);
        beverage1 = new Sugar(beverage1);
        Console.WriteLine($"{beverage1.GetDescription()} -> ${beverage1.Cost():F2}\n");

        Beverage beverage2 = new Latte();
        beverage2 = new Syrup(beverage2, "Caramel");
        beverage2 = new WhippedCream(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()} -> ${beverage2.Cost():F2}\n");

        Beverage beverage3 = new Mocha();
        beverage3 = new Milk(new Syrup(beverage3, "Hazelnut"));
        beverage3 = new Sugar(beverage3);
        Console.WriteLine($"{beverage3.GetDescription()} -> ${beverage3.Cost():F2}\n");

        Console.WriteLine("=== Adapter Pattern: Payments ===\n");

        IPaymentProcessor paypal = new PayPalPaymentProcessor();
        paypal.ProcessPayment(5.75);

        StripePaymentService stripeService = new StripePaymentService();
        IPaymentProcessor stripeAdapter = new StripePaymentAdapter(stripeService);
        stripeAdapter.ProcessPayment(12.40);

        SquarePaymentGateway square = new SquarePaymentGateway();
        IPaymentProcessor squareAdapter = new SquarePaymentAdapter(square);
        squareAdapter.ProcessPayment(7.99);

        Console.WriteLine("\nAll done. Press Enter to exit...");
        Console.ReadLine();
    }
}
