public class Milk : BeverageDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.30;
    }
}
