public class UpiPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine($"Paid {amount} using UPI.");
    }
}