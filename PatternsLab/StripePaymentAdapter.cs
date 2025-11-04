public class StripePaymentAdapter : IPaymentProcessor
{
    private StripePaymentService _stripe;

    public StripePaymentAdapter(StripePaymentService stripe)
    {
        _stripe = stripe;
    }

    public void ProcessPayment(double amount)
    {
        _stripe.MakeTransaction(amount);
    }
}
