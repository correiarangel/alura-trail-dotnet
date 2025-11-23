class Video(string nome,int _duracaoEmSegundos) : Midia(nome)
{
    public int DuracaoEmSegundos { get; set; } = _duracaoEmSegundos;


    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome}, Duração: {DuracaoEmSegundos} segundos");
    }
}