class EventoMusical(string nome, string local, DateTime data, List<Artista> artistasParticipantes)
{
    public string Nome { get; set; } = nome;
    public string Local { get; set; } = local;
    public DateTime Data { get; set; } = data;
    public List<Artista> ArtistasParticipantes { get; set; } = artistasParticipantes;
}

//Representa um evento musical, como um show ao vivo ou um festival, contendo informações como local, data, lista de artistas participantes, etc.