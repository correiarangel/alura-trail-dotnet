using OperacoesEmCoolecoes.Models;

class ByArtist : IComparer<Music>
{
    public int Compare(Music? x, Music? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artisct.CompareTo(y.Artisct);
    }

}