namespace BarberShop;

public class Barbero
{
    public string Rol { get; set; } = string.Empty;
    public bool isBarbero { get; set; }
    public List<Sucursal> listaSucursales = new List<Sucursal>();

    public void VerificarCita(ICitasCollection citas)
    {
        var iterator = citas.CreateIterator();
        while (iterator.HasNext())
        {
            var cita = iterator.Next();
            Console.WriteLine($"Cita: {cita}");
        }
    }

    public void AgregarSucursal(string nombreSucursal, string direccion)
    {
        Random idRandom = new Random();
        Sucursal sucursal = new Sucursal(idRandom.Next(), nombreSucursal, direccion);
        listaSucursales.Add(sucursal);
        Console.WriteLine("Sucursal agregada con éxito.");
    }
}
