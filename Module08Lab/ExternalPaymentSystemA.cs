using System;

public class ExternalPaymentSystemA
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Making payment of {amount} via External Payment System A.");
    }

    public void MakeRefund(double amount)
    {
        Console.WriteLine($"Making refund of {amount} via External Payment System A.");
    }
}
