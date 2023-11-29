namespace BarberShop;

public interface IPaymentMethod
{
    void Pay(int amount);
}

public class Payments : IPaymentMethod
{
    public int Id { get; set; }
    public int Monto { get; set; }

    public void Pay(int amount)
    {
        Console.WriteLine($"Realizando pago con ID {Id} y monto {Monto}");
    }
}

public class MastercardDecorator : IPaymentMethod
{
    private readonly IPaymentMethod _paymentMethod;

    public MastercardDecorator(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }
    
    public void Pay(int amount)
    {
        Console.WriteLine("Procesando pago con Mastercard");
        _paymentMethod.Pay(amount);
    }
}

public class VisaDecorator : IPaymentMethod
{
    private readonly IPaymentMethod _paymentMethod;

    public VisaDecorator(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }
    
    public void Pay(int amount)
    {
        Console.WriteLine("Procesando pago con Visa");
        _paymentMethod.Pay(amount);
    }
}