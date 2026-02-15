using OperacoesEmCoolecoes.Models;

class ByTitle : IComparer<Music>
{
    public int Compare(Music? x, Music? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Title.CompareTo(y.Title);
    }

}