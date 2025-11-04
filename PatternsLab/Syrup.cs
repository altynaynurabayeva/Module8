public class Syrup : BeverageDecorator
{
    private string _flavor;

    public Syrup(Beverage beverage, string flavor = "Vanilla") : base(beverage)
    {
        _flavor = flavor;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + $", {_flavor} Syrup";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.40;
    }
}
