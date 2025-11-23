class ReservaPresencial(int codigo,string descrcaoTipo,string local): Reserva(codigo)
{

    public string Local { get; set; } = local;
    public string DescrcaoTipo   { get; set; } = descrcaoTipo;
    public override void Confirmar()
    {
        Console.WriteLine($"\nReserva presencial {Codigo} do tipo {DescrcaoTipo} confirmada.\n Local: {Local}");
    }
}