namespace BarberShop;

public class Ventas
{
    public int Id { get; set; }
    public float Total { get; set; }
    public DateTime FechaVenta { get; set; }
    private readonly List<Ventas> listaVentas = new List<Ventas>();

    public void RealizarVenta(float montoTotal)
    {
        Random idRandom = new Random();
        listaVentas.Add(new Ventas()
        {
            Id = idRandom.Next(),
            Total = montoTotal,
            FechaVenta = new DateTime()
        });
    }

    public List<Ventas> ListaVentas()
    {
        return listaVentas;
    }
}