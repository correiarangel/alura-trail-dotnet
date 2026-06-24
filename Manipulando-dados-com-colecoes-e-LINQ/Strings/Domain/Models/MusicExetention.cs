using Strings.Domain.Models;

namespace Strings.Domain.Models;

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
            
            //int _duration = 0; 
            //bool _isDuration = int.TryParse(part[2],out int _duration);
            var music = new Music(
                title: string.IsNullOrWhiteSpace(part[0])?"Sem Titulo disponivel....":part[0],
                artist: string.IsNullOrWhiteSpace(part[1])?"Artista não encontrado...":part[1],
                duration:int.TryParse(part[2],out int _duration)?_duration:0,
                genders: part[3].Split(',', StringSplitOptions.TrimEntries),
                launch:DateTime.TryParse(part[4],out DateTime _lauch )?_lauch:DateTime.Today
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

    static public void GetAndDiplayTable(StreamReader streen)
    {
        var musics = GetMusics(streen).Where(m => m.Artist
            .Equals("Coldplay",StringComparison.OrdinalIgnoreCase))
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

