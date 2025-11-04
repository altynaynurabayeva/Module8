public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override double GetCost()
    {
        return base.GetCost() + 10.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }
}
