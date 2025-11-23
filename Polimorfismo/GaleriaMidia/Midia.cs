using System.Security.Cryptography.X509Certificates;

class  Midia(string nome)
{
    public string Nome { get; set; } = nome;

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Mídia: {Nome}");
    }
}