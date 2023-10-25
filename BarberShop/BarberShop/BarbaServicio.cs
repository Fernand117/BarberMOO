namespace BarberShop;

public class BarbaServicio : IServicio
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public float Precio { get; set; }
    public string Tipo { get; set; }
    public string Imagen { get; set; }
    public List<Producto> ProductosList { get; set; }
    
    public BarbaServicio(int id, string nombre, string descripcion, float precio, string tipo, string imagen)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
        Precio = precio;
        Tipo = tipo;
        Imagen = imagen;
    }
    
    public List<Producto> AgregarProducto(Producto producto)
    {
        ProductosList.Add(new Producto()
        {
            Id = producto.Id,
            Nombre = producto.Nombre,
            Descripcion = producto.Descripcion,
            Precio = producto.Precio,
            Stock = producto.Stock,
            DisponibleEnServicio = producto.DisponibleEnServicio,
            Imagen = producto.Imagen
        });

        return ProductosList;
    }
}