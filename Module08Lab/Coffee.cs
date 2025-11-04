public class Coffee : IBeverage
{
    public double GetCost()
    {
        return 50.0; // базовая цена кофе
    }

    public string GetDescription()
    {
        return "Coffee";
    }
}
