using System.Text.RegularExpressions;

namespace Exceptions.Domain.Models;

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
            Console.WriteLine($"{cont++}\t - Musica: {music.Title} - (Artista: {music.Artist}) - Duração: {music.Duration} seg - Lançamento: [{music.Launch}]");
            cont++;
            //if (cont > 10) break;
        }
        Console.WriteLine($"\nFim de exibição de músicas\n");
    }

    public static void DisplayArtists(IEnumerable<string> artists)
    {
        var cont = 1;
        Console.WriteLine($"\nExibindo as músicas:\n");
        foreach (var artidt in artists)
        {
            Console.WriteLine($"{cont++}\t - (Artista: {artidt})]");
            cont++;
        }
        Console.WriteLine($"\nFim de exibição de artistas\n");
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
            int duration = 0;
            // "The Broken Road;Rolling Stones;6:39;Rock, Blues Rock;13/09/1974	
            var match = Regex.Match(line, @"(\d?\d):(\d\d)");
            if (match.Success)
            {
                foreach (var group in match.Groups)
                {

                    var min = int.Parse(match.Groups[1].Value);
                    var seg = int.Parse(match.Groups[2].Value);
                    //Console.WriteLine($"Duração encontrada: {(min * 60) + seg}");
                    duration = (min * 60) + seg;
                }
            }
            var part = line.Split(';');

            var music = new Music(
                title: string.IsNullOrWhiteSpace(part[0]) ? "Sem Titulo disponivel...." : part[0],
                artist: string.IsNullOrWhiteSpace(part[1]) ? "Artista não encontrado..." : part[1],
                duration: duration, //int.TryParse(part[2], out int _duration) ? _duration : 0,
                genders: part[3].Split(',', StringSplitOptions.TrimEntries),
                launch: DateTime.TryParse(part[4], out DateTime _lauch) ? _lauch : DateTime.Today
            );
            yield return music;
            line = stream.ReadLine();
        }
    }


    static public void EditTitle(StreamReader streen)
    {
        var music = GetMusics(streen).Where(m => m.Title.StartsWith('T'))
        .FirstOrDefault();

        if (music is not null)
        {
            Console.WriteLine($"Título da música: {music.Title}"); // interpolação
        }


        if (music is not null)
        {
            music.Title = music.Title.Replace("The ", ""); // imutabilidade
            Console.WriteLine($"Título da música: {music.Title}"); // interpolação

            music.Title = music.Title.ToUpper();
            Console.WriteLine($"Título da música UPCASE: {music.Title}"); // interpolação
        }
    }

    static public void GetAndListSongsTake50(StreamReader streen)
    {
        var musics = GetMusics(streen).Take(50);

        DisplayMusics(musics);
    }
    static public void GetArtistRegex(StreamReader streen)
    {
        var regex1 = new Regex(@"[^a-zA-Z0-9 ]");

        var artists = GetMusics(streen)
            .Where(m => regex1.IsMatch(m.Artist))
            .Select(m => m.Artist)
            .Distinct()
            .OrderBy(a => a);

        DisplayArtists(artists);
    }

    static public void GetMusicRegexTwoText(StreamReader streen)
    {
        string pattern = @"^\w+ \w+$";

        var regex = new Regex(pattern);
        var regexSongsThatStartAndEndWithTheSameWord = new Regex(@"^(\w+).*\1$");
        var regexSongsWithRepeatedLyric = new Regex(@"(\w)\1{2,}");
        var regexTitlesWithRomanNumerals = new Regex(@"\b[IVXLCDM]+\b");
        
        var musics = GetMusics(streen)
        .Where(m => regexSongsWithRepeatedLyric.IsMatch(m.Title))
        .Take(50);

        DisplayMusics(musics);
    }

    static public void GetAndDiplayTable(StreamReader streen)
    {
        var musics = GetMusics(streen).Where(m => m.Artist
            .Equals("Coldplay", StringComparison.OrdinalIgnoreCase))
            .Take(50);

        var collumTitle = "Titulo".PadRight(40);
        var collumArtist = "Artista".PadRight(30);
        var collumDuration = "Duração".PadRight(10);
        var collumLanch = "Lançada Em".PadRight(15);


        Console.WriteLine($"{collumTitle}{collumArtist}{collumDuration}{collumLanch}");
        var borda = "".PadRight(100, '=');
        Console.WriteLine(borda);

        foreach (var music in musics)
        {
            var linha = $"{music.Title,-40}{music.Artist,-30}{music.Duration / 60.0,-10:F3}{music.Launch,-15:dd/MM/yyyy}";
            Console.WriteLine(linha);
        }

    }
}

