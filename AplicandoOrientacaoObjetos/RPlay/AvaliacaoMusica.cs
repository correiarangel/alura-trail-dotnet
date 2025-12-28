class AvaliacaoMusica(int nota, string comentario, Usuario usuario, Musica musica)
{
    public int Nota { get; set; } = nota;
    public string Comentario { get; set; } = comentario;
    public Usuario Usuario { get; set; } = usuario;
    public Musica Musica { get; set; } = musica;

    public void ExibirAvaliacao()
    {
        Console.WriteLine($"Avaliação de {Usuario.Nome} para a música {Musica.Nome}:");
        Console.WriteLine($"Nota: {Nota}/5");
        Console.WriteLine($"Comentário: {Comentario}");
    }
}
//Representa a avaliação de uma música por um usuário, incluindo a nota atribuída e possíveis comentários.