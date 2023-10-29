namespace BarberShop;

public class ServicioFactory
{
    public void AgregarServicio(string tipoServicio, int id, string nombre, string descripcion, float precio, string tipo, string imagen, Producto producto)
    {
        switch (tipoServicio)
        {
            case "Barba":
                BarbaServicio barbaServicio = new BarbaServicio(id, nombre, descripcion, precio, tipo, imagen);
                barbaServicio.AgregarProducto(producto);
                break;
            case "Corte de cabello":
                CabelloServicio cabelloServicio = new CabelloServicio(id, nombre, descripcion, precio, tipo, imagen);
                cabelloServicio.AgregarProducto(producto);
                break;
            default:
                Console.WriteLine("Ingrese un tipo de servicio Barba/Cabello");
                break;
        }
    }
}
