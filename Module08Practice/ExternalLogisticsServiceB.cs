using System;

public class ExternalLogisticsServiceB
{
    public void SendPackage(string packageInfo)
    {
        Console.WriteLine($"[External B] Sending package {packageInfo}...");
    }

    public string CheckPackageStatus(string trackingCode)
    {
        return $"[External B] Package {trackingCode} delivered.";
    }
}
