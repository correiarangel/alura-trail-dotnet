class Album(string nome)
{
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; } = nome;

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        Console.WriteLine($"-----------------------------------");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal} minutos.\n");
    }
}