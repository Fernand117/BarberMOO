namespace BarberShop;

public interface IServicio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public float Precio { get; set; }
    public string Tipo { get; set; }
    public string Imagen { get; set; }
    public List<Producto> ProductosList { get; set; }

    public List<Producto> AgregarProducto(Producto producto);
}