class Conteudo(string titulo)
{
    public string Titulo { get; set; } = titulo;

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Conteúdo: {Titulo}");
    }
}