namespace BarberShop;

public class Program
{
    public static void Main()
    {
        Cliente cliente = new Cliente();
        cliente.Id = new Random().Next();
        Console.Write("Ingrese su usuario: ");
        cliente.Usuario = Console.ReadLine()!.ToString();
        
        Console.Write("Ingrese su correo: ");
        cliente.Correo = Console.ReadLine()!.ToString();
        
        Console.Write("Ingrese su contraseña: ");
        cliente.Password = Console.ReadLine()!.ToString();

        // Crear instancia de Citas
        ICitasCollection citas = new Citas();
        
        // Agendar algunas citas
        citas.AgendarCita(DateTime.Now.AddDays(1));
        citas.AgendarCita(DateTime.Now.AddDays(7));
        citas.AgendarCita(DateTime.Now.AddDays(14));

        // Obtener el iterador y recorrer las citas
        var iterator = citas.CreateIterator();
        while (iterator.HasNext())
        {
            var cita = iterator.Next();
            Console.WriteLine($"Cita: {cita}");
        }

        Citas citaPay = new Citas();
        citaPay.Pagar(150);
        
        bool isBarbero = cliente.SerBarbero();
        Console.WriteLine("Opción de ser barbero en: " + isBarbero);

        Barbero barbero = new Barbero();
        barbero.Rol = "Administrador";
        barbero.isBarbero = isBarbero;

        Console.Write("Nombre de la sucursal: ");
        string nSucursal = Console.ReadLine()!.ToString();

        Console.Write("Direccion sucursal");
        string direccionSucursal = Console.ReadLine()!.ToString();
        
        barbero.AgregarSucursal(nSucursal, direccionSucursal);
        
        foreach (var item in barbero.listaSucursales)
        {
            Console.WriteLine("Suc ID: " + item.Id);
            Console.WriteLine("SUc: Nombre" + item.NombreSucursal);
            Console.WriteLine("Suc: Direccion" + item.Direccion);
        }

        Kit kit = new Kit();
        kit.AgregarServicio("Barba", new Random().Next(), "Corte de barba", "Corte estilo clásico", 256, "Barba",
            "imagne", new Producto()
            {
                Id = new Random().Next(),
                Nombre = "Spray",
                Descripcion = "Spray para barba",
                DisponibleEnServicio = true,
                Imagen = "foto",
                Precio = 19,
                Stock = 9
            });
        
        kit.AgregarServicio("Corte de cabello", new Random().Next(), "Corte de cabello", "Corte estilo moicano", 256, "Cabello",
            "imagne", new Producto()
            {
                Id = new Random().Next(),
                Nombre = "Spray",
                Descripcion = "Spray para cabello",
                DisponibleEnServicio = true,
                Imagen = "foto",
                Precio = 19,
                Stock = 9
            });
    }
}
