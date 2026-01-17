using System.Text.Json;
using CheapShark.Domain.Models;
namespace CheapShark.Domain.Models;

class MusicasFavoritas
{
    public string? Nome { get; set; }

    public List<Musica> MusicasFavoriras { get; }

    public MusicasFavoritas(string? nome)
    {
        Nome = nome;
        MusicasFavoriras = [];
    }

    public void ExibeirMUsicasFavoritas()
    {
        Console.WriteLine($"\nMuscas favorita de : {Nome}\n");
        foreach (var mucica in MusicasFavoriras)
        {
            Console.WriteLine($"-  {mucica}");
        }
    }

    public void GerarArquivoJon()
    {

        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musica = MusicasFavoriras
        });

        string nomeDoArquivo = $"musica-favoritad-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine("Aquivo gerado com Sucesso!");

        Console.WriteLine($"\nLocal: {Path.GetFullPath(nomeDoArquivo)}\n");

    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
            foreach (var musica in MusicasFavoriras)
            {
                arquivo.WriteLine($"- {musica.Nome} - Artista: {musica.Artista}");
            }
        }
        Console.WriteLine("txt gerado com sucesso!");
        Console.WriteLine($"\nLocal: {Path.GetFullPath(nomeDoArquivo)}\n");
    }

    internal void AdicionarMusicaFavorita(Musica musica)
    {
        MusicasFavoriras.Add(musica);
    }
}