using System;

public class InternalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of {amount} via internal system.");
    }

    public void RefundPayment(double amount)
    {
        Console.WriteLine($"Refunding payment of {amount} via internal system.");
    }
}
