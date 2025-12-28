class Compartilhamento {
    public void CompartilharMusica(Usuario usuario, Musica musica) {
        Console.WriteLine($"{usuario.Nome} compartilhou a música: {musica.Nome} por {musica.Artista.Nome}");
    }

    public void CompartilharPlaylist(Usuario usuario, Playlist playlist) {
        Console.WriteLine($"{usuario.Nome} compartilhou a playlist: {playlist.Nome}");
    }

    public void CompartilharArtista(Usuario usuario, Artista artista) {
        Console.WriteLine($"{usuario.Nome} compartilhou o artista: {artista.Nome}");
    }
}

// Permite que os usuários compartilhem músicas, playlists ou artistas com outros usuários.
