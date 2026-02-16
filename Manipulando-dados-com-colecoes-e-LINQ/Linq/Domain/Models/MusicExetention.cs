namespace Linq.Domain.Models;

static class MusicExtention
{

    public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> collrctions, Func<T, bool> condition)
    {
        foreach (var alement in collrctions)
        {
            if (condition(alement)) yield return alement;
        }
    }

    public static void DisplayMusics(this IEnumerable<Music> musics)
    {
        var cont = 1;
        Console.WriteLine($"\nExibindo as músicas:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"{cont++}\t - Musica: {music.Title} - (Artista: {music.Artist}) - Duração: {music.Duration} seg");
            cont++;
            if (cont > 10) break;
        }
        Console.WriteLine($"\nFim de exibição de músicas\n");
    }
    public static void Display(IEnumerable<string> colletions)
    {
        var cont = 1;
        Console.WriteLine($"\nExibindo Lista de artistas:\n");
        foreach (var element in colletions)
        {
            Console.WriteLine($"{cont++}\t -(Artista: {element}) ");
            cont++;
            //if (cont > 200) break;
        }
        Console.WriteLine($"\nFim de exibição da Lista de artistas\n");
    }
    static public IEnumerable<Music> GetMusics(StreamReader stream)
    {
        var line = stream.ReadLine();
        while (line is not null)
        {
            var part = line.Split(';');
            var music = new Music(
                title: part[0],
                artist: part[1],
                duration: Convert.ToInt32(part[2]),
                genders: part[3].Split(',').Select(g => g.Trim())
            );
            yield return music;
            line = stream.ReadLine();
        }
    }

    public static IEnumerable<Music> OperationFilterOrderBy(StreamReader streen, string artist, int skip, int take)
    {
        return GetMusics(streen)
        .Where(music => music.Artist.StartsWith(artist))
        .OrderByDescending(mu => mu.Title)
        .ThenBy(m => m.Duration)
        .Skip(5 * skip)
        .Take(take);
    }

    public static IEnumerable<string> FillOrderByArtist(StreamReader streen, int skip = 0, int take = 200)
    {
        return GetMusics(streen)
        .Select(music => music.Artist)
        .Distinct()
        .OrderBy(a => a)
        .Skip(5 * skip)
        .Take(take);
    }

    public static IEnumerable<string> FillOrderByGenders(StreamReader streen, int skip = 0, int take = 200)
    {
        return GetMusics(streen)
        .SelectMany(m => m.Genders)
        .Distinct()
        .OrderBy(g => g)
        .Skip(5 * skip)
        .Take(take);
    }

    public static void MusicStatistics(StreamReader stream)
    {
        var musics = GetMusics(stream).ToList();

        Console.WriteLine($"\n Estatísticas das Músicas:\n");
        Console.WriteLine($"\nExistem {musics.Count()} músicas na coleção.");
        Console.WriteLine($"\nExistem {musics.Count(m => m.Duration >= 300)} músicas com mais do que 10 minutos na coleção.");
        Console.WriteLine($"\nA música com menor duração da coleção leva {musics.Min(m => m.Duration)} segundos.");
        Console.WriteLine($"\nA música com maior duração da coleção leva {musics.Max(m => m.Duration)} segundos.");
        Console.WriteLine($"\nA duração média das músicas da coleção é {musics.Average(m => m.Duration)} segundos.");
        Console.WriteLine($"\nVocê vai levar {musics.Sum(m => m.Duration) / (3600 * 24)} dias para ouvir toda a coleção!");
        Console.WriteLine("\nChegou ao fim do processamento..........\n");
    }

    public static void GroupSongsByArtist(StreamReader stream)
    {
        var artistsGroup = GetMusics(stream).GroupBy(m => m.Artist);

        Console.WriteLine($"\nExibindo as músicas de cada artista.........\n");

        foreach (var musicGrup in artistsGroup.Take(5))
        {
            Console.WriteLine($"\nArtista: {musicGrup.Key}");
            foreach (var music in musicGrup)
            {
                Console.WriteLine($"\t - {music.Title}");
            }
        }

        Console.WriteLine("\nChegou ao fim do processamento..........\n");

    }
    public static void OperationsForObtainingElements(StreamReader stream)
    {
        var musics = GetMusics(stream).ToList();

        Console.WriteLine($"A primeira musica da lista é: {musics.First()}");
        var longerDuration = musics.MaxBy(m => m.Duration);

        if (longerDuration is not null)
        {
            Console.WriteLine($"A música com maior duração é {longerDuration.Title} com {longerDuration.Duration} segundos.");
        }
    }

    public static void ArtistWithTheMostSongs(StreamReader stream)
    {
        var artistWithTheMostNumberOfSongs = GetMusics(stream)
        .GroupBy(m => m.Artist)
        .Select(g => new { Artist = g.Key, Musics = g, Total = g.Count() })
        .MaxBy(a => a.Total);

        if (artistWithTheMostNumberOfSongs is not null)
        {
            Console.WriteLine($"\nO artista com maior qtde de músicas é {artistWithTheMostNumberOfSongs.Artist} com {artistWithTheMostNumberOfSongs.Total} músicas!\n");
        }
    }

    public static void ExistenceVerificationOperations(StreamReader stream)
    {
        var musics = GetMusics(stream).ToList();

        var artits = musics.GroupBy(m => m.Artist)
            .Where(g => g.Any(m => m.Duration >= 480));

        Console.WriteLine($"\nMusicas com maior duração -----------\n");
        foreach (var artist in artits)
        {
            Console.WriteLine($"\t-{artist.Key}");
        }


        Console.WriteLine($"\n---------------------------\n");
    }

    public static void ExistenceVerificationOperations(StreamReader stream,string genders)
    {
        var musics = GetMusics(stream).ToList();
        var reggae = musics
            .GroupBy(m => m.Artist)
            .Where(g => g.Any(m => m.Genders.Contains(genders)));

        Console.WriteLine($"\nCatores de Reggae -----------\n");
        foreach (var artist in reggae)
        {
            Console.WriteLine($"\t- {artist.Key}");
        }
        Console.WriteLine($"\n---------------------------\n");
    }

}

