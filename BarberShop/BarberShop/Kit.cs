namespace BarberShop;

public class Kit : IKitPrototype
{
    public int Id { get; set; }
    public bool Publico { get; set; }
    public float Costo { get; set; }

    public List<Producto> ListaProductos = new List<Producto>();
    public List<ServicioFactory> ListaServicios = new List<ServicioFactory>();
    
    public Kit Clone(Kit kit)
    {
        return new Kit()
        {
            Id = kit.Id,
            Publico = kit.Publico,
            Costo = kit.Costo
        };
    }

    public List<Producto> AgregarProductos(Producto producto)
    {
        ListaProductos.Add(new Producto()
        {
            Id = producto.Id,
            Nombre = producto.Nombre,
            Descripcion = producto.Descripcion,
            Precio = producto.Precio,
            Stock = producto.Stock,
            DisponibleEnServicio = producto.DisponibleEnServicio,
            Imagen = producto.Imagen
        });

        return ListaProductos.ToList();
    }

    public List<ServicioFactory> AgregarServicio(string tipoServicio, int id, string nombre, string descripcion, float precio,
        string tipo, string imagen, Producto producto)
    {
        ServicioFactory servicioFactory = new ServicioFactory();
        servicioFactory.AgregarServicio(tipoServicio, id, nombre, descripcion, precio, tipo, imagen, producto);
        
        ListaServicios.Add(servicioFactory);
        
        return ListaServicios;
    }
}