namespace Linq.Domain.Models;

class Music(string title, string artist, int duration, IEnumerable<string>? genders)
{
    public string Title { get; set; } = title;
    public string Artist { get; set; } = artist;
    public int Duration { get; set; } = duration;
    public IEnumerable<string> Genders { get; set; } = genders ?? [];
}
