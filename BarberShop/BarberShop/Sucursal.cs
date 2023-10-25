namespace BarberShop;

public class Sucursal
{
    public int Id { get; set; }
    public string NombreSucursal { get; set; }
    public string Direccion { get; set; }
    
    public Sucursal(int id, string nombreSucursal, string direccion)
    {
        Id = id;
        NombreSucursal = nombreSucursal;
        Direccion = direccion;
    }
}
