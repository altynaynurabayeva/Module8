public abstract class BeverageDecorator : Beverage
{
    protected Beverage _beverage;

    public BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription();
    }
}
