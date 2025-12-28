class Notificacao
{
    public string Titulo { get; set; }
    public string Mensagem { get; set; }
    public DateTime DataEnvio { get; set; }

    public Notificacao(string titulo, string mensagem)
    {
        Titulo = titulo;
        Mensagem = mensagem;
        DataEnvio = DateTime.Now;
    }

    public void ExibirNotificacao()
    {
        Console.WriteLine($"[{DataEnvio}] {Titulo}: {Mensagem}");
    }
}

//Responsável por gerenciar notificações enviadas aos usuários, como atualizações de playlists, lançamentos de álbuns, etc.
