class AulaGravada(string titulo, int duracaoEmMinutos) : Conteudo(titulo)
{
    public int DuracaoEmMinutos { get; set; } = duracaoEmMinutos;

    public override void ExibirInfo()
    {
        Console.WriteLine($"Aula Gravada: {Titulo} - Duração: {DuracaoEmMinutos} minutos");
    }
}