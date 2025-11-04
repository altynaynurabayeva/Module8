using System;

public class SquarePaymentGateway
{
    public void Charge(decimal amountInCents)
    {
        Console.WriteLine($"[SquareGateway] Charging {amountInCents} cents");
        Console.WriteLine("[SquareGateway] Charge OK.");
    }
}
