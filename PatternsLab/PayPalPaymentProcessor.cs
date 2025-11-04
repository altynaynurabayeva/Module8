using System;

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"[PayPal] Processing payment: ${amount:F2}");
        Console.WriteLine("[PayPal] Payment completed.");
    }
}
