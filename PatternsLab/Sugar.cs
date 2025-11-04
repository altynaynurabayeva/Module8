public class Sugar : BeverageDecorator
{
    public Sugar(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Sugar";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.10;
    }
}
