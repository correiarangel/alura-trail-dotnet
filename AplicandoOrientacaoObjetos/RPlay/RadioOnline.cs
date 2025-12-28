class RadioOnline
{
    public string Nome { get; set; }
    public string Frequencia { get; set; }
    public List<Musica> Playlist { get; set; }

    public RadioOnline(string nome, string frequencia)
    {
        Nome = nome;
        Frequencia = frequencia;
        Playlist = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Playlist.Add(musica);
    }

    public void Reproduzir()
    {
        Console.WriteLine($"Reproduzindo rádio online: {Nome} na frequência {Frequencia}");
        foreach (var musica in Playlist)
        {
            Console.WriteLine($"Tocando música: {musica.Nome} por {musica.Artista.Nome}");
        }
    }
}


/// Permite a reprodução contínua de músicas em uma sequência aleatória ou baseada em um gênero ou artista específico.