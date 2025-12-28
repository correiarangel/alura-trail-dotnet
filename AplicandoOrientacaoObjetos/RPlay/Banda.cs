class Banda(string nome)
{
    public string Nome { get;} = nome;

    private List<Album> albums = new List<Album>();

    public void AdicionarAlbum(Album album) {
        albums.Add(album);
    }

    public int TotalDuracao() {
        return albums.Sum(a => a.DuracaoTotal);
    }

    public void ExibirDicografia() {
        Console.WriteLine($"\nDiscografia da banda {Nome}:\n");
        Console.WriteLine($"-----------------------------------");
        foreach (var album in albums) {
            album.ExibirMusicasDoAlbum();
            Console.WriteLine();
        }
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"Duração total da discografia: {TotalDuracao()} minutos\n");
    }
}