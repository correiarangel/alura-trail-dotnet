class GeneroMusical(string nome, string descricao)
{
    public string Nome { get; } = nome;
    public string Descricao { get; } = descricao;
    public List<Artista> Artistas { get; } = new List<Artista>();
    public List<Musica> Musicas { get; } = new List<Musica>();
    public void ExibirInfo()
    {
        Console.WriteLine($"Gênero Musical: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine("Artistas:");
        foreach (var artista in Artistas)
        {
            Console.WriteLine($"- {artista.Nome}");
        }
        Console.WriteLine("Músicas:");
        foreach (var musica in Musicas)
        {
            Console.WriteLine($"- {musica.Nome} por {musica.Artista.Nome}");
        }
    }

}

//Representa um gênero musical, contendo informações como nome, descrição, lista de artistas ou músicas associadas, etc.