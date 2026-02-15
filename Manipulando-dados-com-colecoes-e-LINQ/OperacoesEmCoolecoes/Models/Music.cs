namespace OperacoesEmCoolecoes.Models;

class Music(string title, string artisct, int duration)//:IComparable
{
    public string Title { get; set; } = title;
    public string Artisct { get; set; } = artisct;
    public int Duration { get; set; } = duration;

    /* public int CompareTo(object? obj)
     {
         if(obj is null)return 1;
         Music outherMusic = obj as Music;
         return this.Duration.CompareTo(outherMusic);
     }*/
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Music outherMusic)
            return this.Title.Equals(outherMusic.Title) && this.Artisct.Equals(outherMusic.Artisct);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Title.GetHashCode() ^ this.Artisct.GetHashCode();
    }
}