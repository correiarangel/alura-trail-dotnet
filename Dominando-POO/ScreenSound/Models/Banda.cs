namespace ScreenSound.Models;

internal class Banda(string nome)
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public string? Resumo {get;set;} = string.Empty;

    public string Nome { get; } = nome;
    public double Media
    {
        get
        {
            if (notas.Count == 0)
            {
                return 0;
            }
            return notas.Average(n => n.Nota);
        }
    }
    public IEnumerable<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
    public void ExibirNotas()
    {
        Console.WriteLine($"Notas da música {Nome}:");
        foreach (var nota in notas)
        {
            Console.WriteLine(nota);
        }
    }
}