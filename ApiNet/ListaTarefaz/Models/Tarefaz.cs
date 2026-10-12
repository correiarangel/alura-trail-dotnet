namespace ListaTarefaz.Models;

public class Tarefaz
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public bool Concluida { get; set; } = false;
    public DateOnly DataCriacao { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    public DateOnly? DataConclusao { get; set; }

    public Tarefaz() { }

    public Tarefaz(string titulo, string descricao, DateOnly? dataConclusao = null)
    {
        Titulo = titulo;
        Descricao = descricao;
        Concluida = false;
        DataCriacao = DateOnly.FromDateTime(DateTime.UtcNow);
        DataConclusao = dataConclusao;
    }
}
