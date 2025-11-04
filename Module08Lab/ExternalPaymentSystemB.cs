using System;

public class ExternalPaymentSystemB
{
    public void SendPayment(double amount)
    {
        Console.WriteLine($"Sending payment of {amount} via External Payment System B.");
    }

    public void ProcessRefund(double amount)
    {
        Console.WriteLine($"Processing refund of {amount} via External Payment System B.");
    }
}
