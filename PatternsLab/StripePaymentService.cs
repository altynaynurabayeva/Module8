using System;

public class StripePaymentService
{
    public void MakeTransaction(double totalAmount)
    {
        Console.WriteLine($"[StripeService] Making transaction for ${totalAmount:F2}");
        Console.WriteLine("[StripeService] Transaction successful.");
    }
}
