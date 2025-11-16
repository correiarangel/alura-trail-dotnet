class Computador
{
    public Processador Processador { get; set; }
    public PlacaMae PlacaMae { get; set; }

    public Computador(Processador processador, PlacaMae placaMae)
    {
        Processador = processador;
        PlacaMae = placaMae;
    }

    public void ExibirConfiguracao()
    {
        Console.WriteLine("Configuração do Computador:");
        Console.WriteLine($"Processador: {Processador.Marca} {Processador.Modelo}");
        Console.WriteLine($"Placa Mãe: {PlacaMae.Fabricante} - Socket: {PlacaMae.Socket}");
    }
}