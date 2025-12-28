class Artista
{
    public string Nome { get; set; }
    public string Biografia { get; set; }
    public List<Album> Albuns { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public GeneroMusical GeneroMusical { get; set; }

    public Artista(string nome, string biografia, DateTime dataDeNascimento, GeneroMusical generoMusical)
    {
        Nome = nome;
        Biografia = biografia;
        DataDeNascimento = dataDeNascimento;
        GeneroMusical = generoMusical;
        Albuns = new List<Album>();
    }

    public void AdicionarAlbum(Album album)
    {
        Albuns.Add(album);
    }
}
    
    /// Representa um artista musical, contendo informações como nome, biografia, lista de álbuns, etc.
    /// 
    /// 