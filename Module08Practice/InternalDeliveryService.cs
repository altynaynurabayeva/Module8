using System;

public class InternalDeliveryService : IInternalDeliveryService
{
    public void DeliverOrder(string orderId)
    {
        Console.WriteLine($"[Internal] Delivering order {orderId}...");
    }

    public string GetDeliveryStatus(string orderId)
    {
        return $"[Internal] Order {orderId} delivered successfully.";
    }
}
