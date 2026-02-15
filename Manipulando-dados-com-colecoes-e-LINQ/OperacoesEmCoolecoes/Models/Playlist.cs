using System.Collections;

namespace OperacoesEmCoolecoes.Models;

class Playlist(string name) : ICollection<Music>
{
    private List<Music> musics = [];
    private HashSet<Music> listMusic = [];
  
    public string Name { get; set; } = name;

    public int Count => musics.Count;

    public bool IsReadOnly => false;

    public void Add(Music item)
    {
        if (listMusic.Add(item)) musics.Add(item);
    }

    public void Clear() => musics.Clear();

    public bool Contains(Music item)
    {
        return musics.Contains(item);
    }

    public void CopyTo(Music[] array, int arrayIndex)
    {
        musics.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Music> GetEnumerator()
    {
        return musics.GetEnumerator();
    }

    public bool Remove(Music item)
    {
        return musics.Remove(item);
    }

    public void DisplayPlaylist(Playlist playlist)
    {
        Console.WriteLine($"\n Tocando as musicas de {playlist.Name}");
        foreach (var musica in playlist)
        {
            Console.WriteLine($"\t - {musica.Title} - {musica.Artisct} - {musica.Duration}");
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Music? FindForTitle(string value)
    {
        return musics.Find(music => music.Title == value);
    }

    public void OderByDuration() => musics.Sort(new ByDuration());

    public void OderByTitle() => musics.Sort(new ByTitle());

    public void OderByArtist() => musics.Sort(new ByArtist());

    public static void DisplayMostPlayed(Playlist playlist1, Playlist playlist2)
    {
        Dictionary<Music, int> rank = new Dictionary<Music, int>();
        foreach (var item in playlist1)
        {
            rank.Add(item, 1);
        }

        foreach (var music in playlist2)
        {
            if (rank.TryGetValue(music, out int cont))
            {
                cont++;
                rank[music] = cont;
            }
            else
            {
                rank[music] = 1;
            }
        }

        List<KeyValuePair<Music, int>> topRank = new List<KeyValuePair<Music, int>>(rank);

        topRank.Sort(new ByCont());

        Console.WriteLine("\nTop 3 músicas mais incluídas nas playlists:");

        int conter = 1;
        foreach (var par in topRank)
        {
            Console.WriteLine($"\t - {par.Key.Title}");
            conter++;
            if (conter > 3) break;
        }
    }


}