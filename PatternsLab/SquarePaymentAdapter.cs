public class SquarePaymentAdapter : IPaymentProcessor
{
    private SquarePaymentGateway _gateway;

    public SquarePaymentAdapter(SquarePaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void ProcessPayment(double amount)
    {
        decimal cents = (decimal)(amount * 100);
        _gateway.Charge(cents);
    }
}
