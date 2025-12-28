class Podcast(string nome, string host, DateTime dataLancamento)
{
    public string Nome { get; } = nome;
    public string Host { get; } = host;
    public DateTime DataLancamento { get; } = dataLancamento;

    public List<Episodio> episodios { get; set; } =new();

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio) {
        episodios.Add(episodio);
    }

    public void ExibirEpisodios() {
        Console.WriteLine($"Podcast: {Nome} - Host: {Host} - Data de Lançamento: {DataLancamento.ToShortDateString()}");
        Console.WriteLine($"Total de Episódios: {TotalEpisodios}");
        foreach (var episodio in episodios) {
            Console.WriteLine(episodio.Resumo);
        }
    }

}

//Representa um episódio de um podcast, contendo informações como título, descrição, duração, etc.
