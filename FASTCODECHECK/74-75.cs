using System;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
public class StripePaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} with Stripe."); 
    }
}
public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} with PayPal."); 
    }
}
public class CryptoPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} with Crypto.");
    }
}
public class PaymentService
{
    private readonly IPaymentProcessor _paymentProcessor;

    public PaymentService(IPaymentProcessor paymentProcessor)
    {
        _paymentProcessor = paymentProcessor;
    }

    public void ExecutePayment(decimal amount)
    {
        // Валидация
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be greater than zero.");
        }

        // Логирование
        Console.WriteLine($"Initiating payment of {amount}.");

        // Обработка платежа
        _paymentProcessor.ProcessPayment(amount);

        // Логирование завершения
        Console.WriteLine($"Payment of {amount} processed successfully.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // использования Stripe
        IPaymentProcessor stripeProcessor = new StripePaymentProcessor();
        PaymentService stripePaymentService = new PaymentService(stripeProcessor);
        stripePaymentService.ExecutePayment(100.50m);

        // использования PayPal
        IPaymentProcessor paypalProcessor = new PayPalPaymentProcessor();
        PaymentService paypalPaymentService = new PaymentService(paypalProcessor);
        paypalPaymentService.ExecutePayment(200.75m);

        // использования Crypto
        IPaymentProcessor cryptoProcessor = new CryptoPaymentProcessor();
        PaymentService cryptoPaymentService = new PaymentService(cryptoProcessor);
        cryptoPaymentService.ExecutePayment(300.00m);
    }
}
