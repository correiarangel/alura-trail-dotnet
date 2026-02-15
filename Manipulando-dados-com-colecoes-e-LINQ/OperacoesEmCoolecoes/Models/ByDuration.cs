using OperacoesEmCoolecoes.Models;

class ByDuration : IComparer<Music>
{
    public int Compare(Music? x, Music? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Duration.CompareTo(y.Duration);
    }

}