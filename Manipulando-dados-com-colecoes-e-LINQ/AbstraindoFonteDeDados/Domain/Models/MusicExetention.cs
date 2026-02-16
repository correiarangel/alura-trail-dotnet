namespace AbstraindoFonteDeDados.Domain.Models;

static class MusicExtention
{


    public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> collrctions, Func<T, bool> condition)
    {
        foreach (var alement in collrctions)
        {
            if (condition(alement)) yield return alement;
        }
    }
    //public static IEnumerable<Music> FillterMusicByArtist(this IEnumerable<Music> musics, string? artist)
    //{
    //    foreach (var music in musics)
    //    {
    //        if (music.Artist == artist) yield return music;
    //    }
    //}
    public static bool FillterMusicByCondeplay(Music music) => music.Artist == "Coldplay";
    public static bool FillterMusicByMetallica(Music music) => music.Artist == "Metallica";
    public static bool FillterMusicByTitas(Music music) => music.Artist == "Titas";
    public static bool FillterMusicDurationLoong(Music music) => music.Duration >= 350;
    public static bool FillterMusicByStartA(Music music) => music.Title.StartsWith("A");

    public static IEnumerable<Music> FillterMusicByTitle(this IEnumerable<Music> musics, string? title)
    {
        foreach (var music in musics)
        {
            if (music.Title == title) yield return music;
        }
    }

    public static IEnumerable<Music> FillterMusicByDuration(this IEnumerable<Music> musics, string duration)
    {
        int _duration = 0;
        if (duration is not null) _duration = Convert.ToInt32(duration);

        foreach (var music in musics)
        {
            if (music.Duration >= _duration) yield return music;
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

}
