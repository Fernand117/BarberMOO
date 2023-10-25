namespace BarberShop;

public class Kit : IKitPrototype
{
    public int Id { get; set; }
    public bool Publico { get; set; }
    public float Costo { get; set; }
    
    public Kit Clone(Kit kit)
    {
        return new Kit()
        {
            Id = kit.Id,
            Publico = kit.Publico,
            Costo = kit.Costo
        };
    }
}