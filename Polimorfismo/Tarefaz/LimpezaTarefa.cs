namespace Tarefaz;

class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Iniciando tarefa de limpeza...");
        // Lógica de limpeza aqui
        Console.WriteLine("Tarefa de limpeza concluída com sucesso!");
    }
}