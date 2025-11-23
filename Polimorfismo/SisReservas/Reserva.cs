class Reserva(int codigo)
{
    public int Codigo { get; set; } = codigo;

    public virtual void Confirmar()
    {
        Console.WriteLine($"Reserva {Codigo} confirmada.");
    }
}