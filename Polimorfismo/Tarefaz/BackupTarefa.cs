
namespace Tarefaz;

class BackupTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Iniciando backup dos dados...");
        // Lógica de backup aqui
        Console.WriteLine("Backup concluído com sucesso!");
    }
}