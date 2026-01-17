using CheapShark.Domain.Models;

namespace CheapShark.Domain.Filter;

internal class LingFilter
{
    public static void FilterAllGenerisMusics(List<Musica> musics)
    {
        var allGenerisMusics = musics.Select(g => g.Genero).Distinct().ToList();
        foreach (var genero in allGenerisMusics)
        {
            Console.WriteLine($" - {genero}");
        }
    }

    public static void FilterAllArtistsOrderByArtist(List<Musica> musics)
    {

        var allGenerisMusics = musics.OrderBy(m => m.Artista).Select(g => g.Artista).Distinct().ToList();
        foreach (var genero in allGenerisMusics)
        {
            Console.WriteLine($" - {genero}");
        }
    }
    public static void FilterAllGenerisMusics(List<Musica> musics, string genery)
    {
        var allGenerisMusics = musics.Where(m =>  m.Genero.Contains(genery) ).Select(m=> m.Artista).Distinct().ToList();
        foreach (var music in allGenerisMusics)
        {
            Console.WriteLine($" - {music}");
        }
    }

    public static void FilterAllGenerisMusicsArtist(List<Musica> musics, string nameArtist)
    {
        var allGenerisMusics = musics.Where(m =>  m.Artista!.Equals(nameArtist) ).ToList();
        foreach (var music in allGenerisMusics)
        {
            Console.WriteLine($" - {music.Nome}");
        }
    }

    public static void FilterAllGenerisMusicsArtist(List<Musica> musics, int year)
    {
        var musicsYear = musics.Where(musics => musics.Ano == year)
            .OrderBy(musics => musics.Nome) // ordena as músicas pelo nome
    .Select(musics => musics.Nome) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {year}");
        foreach (var music in musicsYear)
        {
            Console.WriteLine($"- {music}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas, string key)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals(key))
            .Select(musica => musica.Nome)
            .ToList();

        Console.WriteLine($"\nMúsicas em {key}:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
        Console.WriteLine($"Fim Músicas em {key} \n");
    }

}
