public class PaymentAdapterA : IPaymentProcessor
{
    private ExternalPaymentSystemA _externalSystemA;

    public PaymentAdapterA(ExternalPaymentSystemA externalSystemA)
    {
        _externalSystemA = externalSystemA;
    }

    public void ProcessPayment(double amount)
    {
        _externalSystemA.MakePayment(amount);
    }

    public void RefundPayment(double amount)
    {
        _externalSystemA.MakeRefund(amount);
    }
}
