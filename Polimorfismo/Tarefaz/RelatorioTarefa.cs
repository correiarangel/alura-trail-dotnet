namespace Tarefaz;

class RelatorioTarefa : TarefaAgendada
{
public override void Executar()
{
    Console.WriteLine("Gerando relatório...");
    // Lógica de geração de relatório aqui
    Console.WriteLine("Relatório gerado com sucesso!");
}
}