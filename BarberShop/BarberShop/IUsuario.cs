namespace BarberShop;

public interface IUsuario
{
    public int Id { get; set; }
    public string Usuario { get; set; }
    public string Correo { get; set; }
    public string Password { get; set; }
    
    public string IniciarSesion(string usuario, string password);
    public string CerrarSesion();
    public string CrearCuenta(string usuario, string correo, string password);
}