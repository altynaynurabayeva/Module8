using System;

public class ExternalLogisticsServiceA
{
    public void ShipItem(int itemId)
    {
        Console.WriteLine($"[External A] Shipping item #{itemId}...");
    }

    public string TrackShipment(int shipmentId)
    {
        return $"[External A] Shipment #{shipmentId} is on the way.";
    }
}
