using System;

public class LogisticsAdapterB : IInternalDeliveryService
{
    private ExternalLogisticsServiceB _externalB = new ExternalLogisticsServiceB();

    public void DeliverOrder(string orderId)
    {
        _externalB.SendPackage(orderId);
    }

    public string GetDeliveryStatus(string orderId)
    {
        return _externalB.CheckPackageStatus(orderId);
    }
}
