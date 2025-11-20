class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext(new CreditCardPayment());
        context.MakePayment(500);

        // Change strategy at runtime
        context.SetStrategy(new UpiPayment());
        context.MakePayment(300);

        context.SetStrategy(new PayPalPayment());
        context.MakePayment(1000);
    }
}
