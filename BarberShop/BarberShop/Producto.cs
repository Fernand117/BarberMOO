namespace BarberShop;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public float Precio { get; set; }
    public int Stock { get; set; }
    public bool DisponibleEnServicio { get; set; }
    public string Imagen { get; set; }
}