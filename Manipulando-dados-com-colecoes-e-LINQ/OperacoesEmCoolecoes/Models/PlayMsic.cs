namespace OperacoesEmCoolecoes.Models
{
    class PlayMusic
    {
        private Queue<Music> queue = new Queue<Music>();
        private Stack<Music> historyStack = new Stack<Music>();
        public void AddQueue(Music music)
        {
            queue.Enqueue(music);
        }

        public void AddQueue(Playlist playlist)
        {
            foreach (var music in playlist)
            {
                AddQueue(music);
            }
        }

        public IEnumerable<Music> Queue()
        {
            foreach (var music in queue)
            {
                yield return music;
            }
        }

        public static void DisplayQueue(PlayMusic player)
        {
            Console.WriteLine($"\nExibindo a fila de reprodução:");
            foreach (var musica in player.Queue())
            {
                Console.WriteLine($"{'\t'} - {musica.Title}");
            }
        }

        public Music? NextSongInQueue()
        {
            if (queue.Count == 0) return null;
            return queue.Dequeue();
        }

        public void DisplayHistory(PlayMusic player)
        {
            Console.WriteLine($"\nExibindo o histórico:");
            foreach (var music in player.historyStack)
            {
                Console.WriteLine($"\t - {music.Title}");
            }
        }
        public Music? PreviousMusic(PlayMusic player)
        {
            if (player.historyStack.Count == 0) return null;
            return historyStack.Pop();
        }
        public IEnumerable<Music> History()
        {
            foreach (var music in historyStack)
            {
                yield return music;
            }
        }
    }
}