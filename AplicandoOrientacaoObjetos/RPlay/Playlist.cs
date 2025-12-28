class Playlist(string nome)
{
    public string Nome { get; set; } = nome;
    public List<Musica> Musicas { get; } = new List<Musica>();

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}
    
//Representa uma coleção de músicas organizadas em uma determinada ordem ou tema.