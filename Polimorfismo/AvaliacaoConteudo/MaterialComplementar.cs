class MaterialComplementar(string titulo, string tipoArquivo) : Conteudo(titulo)
{
    public string TipoArquivo { get; set; } = tipoArquivo;

    public override void ExibirInfo()
    {
        Console.WriteLine($"Material Complementar: {Titulo} - Tipo de Arquivo: {TipoArquivo}");
    }
}