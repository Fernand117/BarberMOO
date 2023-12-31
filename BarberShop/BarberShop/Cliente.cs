namespace BarberShop;

public class Cliente : IUsuario
{
    public int Id { get; set; }
    public string Usuario { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    
    public string IniciarSesion(string usuario, string password)
    {
        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password)) Console.WriteLine("Por favor ingrese un usuario o contraseña");
        return "Bienvenido " + usuario;
    }

    public ICitasCollection AgendarCita()
    {
        ICitasCollection citas = new Citas();
        citas.AgendarCita(DateTime.Now.AddDays(1));
        citas.AgendarCita(DateTime.Now.AddDays(6));
        citas.AgendarCita(DateTime.Now.AddDays(17));
        return citas;
    }

    public string CerrarSesion()
    {
        return "Sesión cerrada con éxito.";
    }

    public string CrearCuenta(string usuario, string correo, string password)
    {
        if (string.IsNullOrEmpty(usuario)) Console.WriteLine("Ingrese un nombre de usuario");
        if (string.IsNullOrEmpty(correo)) Console.WriteLine("Ingrese una dirección de correo");
        if (string.IsNullOrEmpty(password)) Console.WriteLine("Ingrese una contraseña");

        return "Cuenta creada con éxito: " + usuario;
    }

    public bool SerBarbero()
    {
        Barbero barbero = new Barbero();
        barbero.Rol = "Administrador";
        barbero.isBarbero = true;
        return barbero.isBarbero;
    }
}
