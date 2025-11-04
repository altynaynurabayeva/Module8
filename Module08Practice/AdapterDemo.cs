using System;

public static class AdapterDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Adapter Pattern: Logistics ===\n");

        var service1 = DeliveryServiceFactory.GetService("internal");
        service1.DeliverOrder("ORD-101");
        Console.WriteLine(service1.GetDeliveryStatus("ORD-101"));

        var service2 = DeliveryServiceFactory.GetService("A");
        service2.DeliverOrder("ORD-202");
        Console.WriteLine(service2.GetDeliveryStatus("ORD-202"));

        var service3 = DeliveryServiceFactory.GetService("B");
        service3.DeliverOrder("ORD-303");
        Console.WriteLine(service3.GetDeliveryStatus("ORD-303"));

        Console.WriteLine("\nAll deliveries processed.");
    }
}
