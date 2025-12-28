class Musica(string nome, Banda artista)
{
    public string Nome { get; } = nome;

    public Banda Artista { get; } = artista;
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";




    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\n-----------------------------------\n");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
        Console.WriteLine($"-----------------------------------\n");
    }
}