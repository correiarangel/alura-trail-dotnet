class Usuario(string nome, string email, string senha)
{
    public string Nome { get; set; } = nome;
    public string Email { get; set; } = email;
    public string Senha { get; set; } = senha;
    public List<Musica> HistoricoReproducao { get; set; } = new List<Musica>();
    public List<Playlist> PlaylistsCriadas { get; set; } = new List<Playlist>();
}

//Representa um usuário da aplicação, com informações como nome, e-mail, senha, histórico de reprodução, playlists criadas, etc.