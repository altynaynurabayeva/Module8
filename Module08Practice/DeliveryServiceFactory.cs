using System;

public static class DeliveryServiceFactory
{
    public static IInternalDeliveryService GetService(string type)
    {
        return type switch
        {
            "internal" => new InternalDeliveryService(),
            "A" => new LogisticsAdapterA(),
            "B" => new LogisticsAdapterB(),
            _ => throw new ArgumentException("Unknown delivery service type")
        };
    }
}
