using OperacoesEmCoolecoes.Models;

class ByCont : IComparer<KeyValuePair<Music, int>>
{
    public int Compare(KeyValuePair<Music, int> x, KeyValuePair<Music, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}