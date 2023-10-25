namespace BarberShop;

public class Payments
{
    public int Id { get; set; }
    public int Monto { get; set; }

    public int Pagar(int monto)
    {
        Random idRandom = new Random();
        Id = idRandom.Next();
        Monto = monto;

        return monto;
    }
}