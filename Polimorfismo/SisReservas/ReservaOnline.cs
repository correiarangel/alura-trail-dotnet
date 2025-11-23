using System.Formats.Asn1;

class ReservaOnline(int codigo,string descrcaoTipo,string urlLink) : Reserva(codigo)
{
    public string UrlLink { get; set; } = urlLink;
    public string DescrcaoTipo   { get; set; } = descrcaoTipo;
    public override void Confirmar()
    {
        Console.WriteLine($"\nReserva online {Codigo} do tipo {DescrcaoTipo} confirmada.\n Link de acesso: {UrlLink}");
    }
}


