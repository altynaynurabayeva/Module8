public abstract class Beverage
{
    public string Description { get; protected set; } = "Unknown Beverage";
    public virtual string GetDescription() => Description;
    public abstract double Cost();
}
