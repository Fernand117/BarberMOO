namespace BarberShop;

// Interfaz para el iterador de citas
public interface IIterator
{
    bool HasNext();
    DateTime Next();
}

// Interfaz para la colección de citas
public interface ICitasCollection
{
    void AgendarCita(DateTime fecha);
    void ListaCitas();
    IIterator CreateIterator();
    // Otros métodos relevantes...
}

// Implementación base de la colección de citas
public class Citas : ICitasCollection
{
    private List<DateTime> citas = new List<DateTime>();

    public void Pagar(int monto)
    {
        // Crear una instancia de Payments
        var payment = new Payments { Id = 1, Monto = monto };

        // Decorar con Mastercard
        var mastercardPayment = new MastercardDecorator(payment);
        mastercardPayment.Pay(monto);

        // Decorar con Visa
        var visaPayment = new VisaDecorator(payment);
        visaPayment.Pay(monto);
    }

    public void AgendarCita(DateTime fecha)
    {
        citas.Add(fecha);
        Console.WriteLine($"Cita agendada para el {fecha}");
    }

    public void ListaCitas()
    {
        Console.WriteLine("Lista de Citas:");
        foreach (var fecha in citas)
        {
            Console.WriteLine($" - {fecha}");
        }
    }

    public IIterator CreateIterator()
    {
        return new CitasIterator(this);
    }

    public List<DateTime> GetCitas()
    {
        return citas;
    }
    // Otros métodos de Citas...
}

// Implementación del iterador de citas
public class CitasIterator : IIterator
{
    private Citas citasCollection;
    private int index = 0;

    public CitasIterator(Citas citasCollection)
    {
        this.citasCollection = citasCollection;
    }

    public bool HasNext()
    {
        return index < citasCollection.GetCitas().Count;
    }

    public DateTime Next()
    {
        if (HasNext())
        {
            DateTime cita = citasCollection.GetCitas()[index];
            index++;
            return cita;
        }
        else
        {
            return default(DateTime); // o lanza una excepción, dependiendo de tus requerimientos
        }
    }
}

