class Projeto(string nome)
{
    public string Nome { get; } = nome;

    private List<string> tarefas = new List<string>();
    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Tarefas do projeto {Nome}:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"- {tarefa}");
        }
    }
    
    public int QuantidadeTarefas
    {
        get
        {
            return tarefas.Count; 
        }
    }
}


/*

Crie uma classe Projeto com:

Uma propriedade pública Nome.
Uma lista privada de strings chamada tarefas.
Um método público AdicionarTarefa(string tarefa) que insere uma nova tarefa.
Um método público ExibirTarefas() que imprime todas as tarefas.
Uma propriedade somente leitura QuantidadeTarefas, baseada no tamanho da lista.

*/