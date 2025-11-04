using System;

public class LogisticsAdapterA : IInternalDeliveryService
{
    private ExternalLogisticsServiceA _externalA = new ExternalLogisticsServiceA();

    public void DeliverOrder(string orderId)
    {
        int id = int.Parse(orderId.Replace("ORD-", ""));
        _externalA.ShipItem(id);
    }

    public string GetDeliveryStatus(string orderId)
    {
        int id = int.Parse(orderId.Replace("ORD-", ""));
        return _externalA.TrackShipment(id);
    }
}
