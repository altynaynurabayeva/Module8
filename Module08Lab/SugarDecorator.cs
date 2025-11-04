public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage) { }

    public override double GetCost()
    {
        return base.GetCost() + 5.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Sugar";
    }
}
