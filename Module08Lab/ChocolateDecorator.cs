public class ChocolateDecorator : BeverageDecorator
{
    public ChocolateDecorator(IBeverage beverage) : base(beverage) { }

    public override double GetCost()
    {
        return base.GetCost() + 15.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Chocolate";
    }
}
