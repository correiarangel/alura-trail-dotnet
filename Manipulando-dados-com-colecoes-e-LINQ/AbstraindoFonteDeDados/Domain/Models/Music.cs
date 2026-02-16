namespace AbstraindoFonteDeDados.Domain.Models;

class Music(string title, string artist, int duration)
{
    public string Title { get; set; } = title;
    public string Artist { get; set; } = artist;
    public int Duration { get; set; } = duration;

    static public IEnumerable<Music> GetMusics(StreamReader stream)
    {
        var line = stream.ReadLine();
        while (line is not null)
        {
            var part = line.Split(';');
            var music = new Music(
                title : part[0],
                artist : part[1],
                duration : Convert.ToInt32(part[2])
            );
            yield return music;
            line = stream.ReadLine();
        }
    }
}
