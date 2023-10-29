namespace BarberShop;

public class Citas
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string Status { get; set; } = string.Empty;
    
    public readonly List<Citas> listaCitas = new List<Citas>();

    public Citas AgendarCita()
    {
        Random idRandom = new Random();
        
        Payments payments = new Payments();
        int payment = payments.Pagar(idRandom.Next());

        Console.WriteLine("Pago realizado por la cantidad de: $" + payment + "MXN");

        Citas citas = new Citas()
        {
            Id = idRandom.Next(),
            Fecha = new DateTime(),
            Status = "Agendada"
        };
        
        listaCitas.Add(citas);
        
        return citas;
    }

    public string RecordarCita(Citas citas)
    {
        var citaActual = listaCitas.Find(x => x.Id == citas.Id);
        return "Usted tiene un cita pendiente Id: " + citaActual!.Id + " con Fecha: " + citaActual.Fecha;
    }

    public string VencerCita(Citas citas)
    {
        var citaActual = listaCitas.Find(x => x.Id == citas.Id);
        citaActual!.Status = "Cita vencida";

        return "Cita " + citaActual.Id + " vencida";
    }

    public string CancelarCita(Citas citas)
    {
        listaCitas.Remove(listaCitas.Find(x => x.Id == citas.Id));
        return "Cita " + citas.Id + " eliminada.";
    }
}
