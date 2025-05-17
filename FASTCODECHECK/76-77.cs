using System;

class Program
{
    static void Main(string[] args)
    {
        OrderHandler productHandler = new ProductAvailabilityHandler();
        OrderHandler paymentHandler = new PaymentVerificationHandler();
        OrderHandler addressHandler = new DeliveryAddressHandler();

        productHandler.SetNext(paymentHandler);
        paymentHandler.SetNext(addressHandler);

        var order = new Order(true, true, true);

        productHandler.Handle(order);
    }
}

public abstract class OrderHandler
{
    protected OrderHandler nextHandler;

    public void SetNext(OrderHandler handler)
    {
        nextHandler = handler;
    }

    public virtual void Handle(Order order)
    {
        nextHandler?.Handle(order);
    }
}
public class ProductAvailabilityHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        if (order.ProductAvailable)
        {
            Console.WriteLine("Товар доступен для заказа.");
            base.Handle(order);
        }
        else
        {
            Console.WriteLine("Товар недоступен.");
        }
    }
}
public class PaymentVerificationHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        if (order.PaymentSuccessful)
        {
            Console.WriteLine("Платеж подтвержден.");
            base.Handle(order);
        }
        else
        {
            Console.WriteLine("Ошибка платежа.");
        }
    }
}
public class DeliveryAddressHandler : OrderHandler
{
    public override void Handle(Order order)
    {
        if (order.AddressValid)
        {
            Console.WriteLine("Адрес доставки корректен.");
            base.Handle(order);
        }
        else
        {
            Console.WriteLine("Некорректный адрес доставки.");
        }
    }
}
public class Order
{
    public bool ProductAvailable { get; set; }
    public bool PaymentSuccessful { get; set; }
    public bool AddressValid { get; set; }

    public Order(bool productAvailable, bool paymentSuccessful, bool addressValid)
    {
        ProductAvailable = productAvailable;
        PaymentSuccessful = paymentSuccessful;
        AddressValid = addressValid;
    }
}
