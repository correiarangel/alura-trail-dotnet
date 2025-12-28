class Episodio(int ordem, string titulo, int duracaoEmMinutos)
{
    List<string> convidados = new List<string>();
    public int Ordem { get; } = ordem;
    public string Titulo { get; } = titulo;
    public int DuracaoEmMinutos { get; } = duracaoEmMinutos;

    public  string  Resumo => $"Episódio {Ordem}: {Titulo} - Duração: {DuracaoEmMinutos} minutos";

    public void AdicionarConvidado(string nomeDoConvidado) {
        convidados.Add(nomeDoConvidado);
    }
}