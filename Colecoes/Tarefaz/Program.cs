
using System.Threading.Tasks;

internal partial class Program
{
    static Dictionary<string, string> tarefaz = new Dictionary<string, string>()
        {
            { "Refatorar módulo de login", "Ana" },
            { "Testar API de pagamentos", "Pedro" },
             { "Criar Filtro para boletos", "Julia" }
        };
    private static void Main(string[] args)
    {
        Console.WriteLine("\nTAREFAZ");
        ListInventario("Lista de  tarefaz"); ;
        CleanList();
        Add();
        ListInventario("Tarefas da próxima sprint:");
    }

    static async void CleanList()
    {
        Console.WriteLine("\nTarefaz removidas .......");
        tarefaz.Clear();
    }
    static async void Add()
    {
         Console.WriteLine("\nTarefaz adicionadas .......");
        tarefaz.Add("Implementar autenticação OAuth", "João");
        tarefaz.Add("Otimizar consultas SQL", "Maria");
        tarefaz.Add("Atualizar documentação", "Carlos");
    }

    static async void ListInventario(string msg)
    {
        Console.WriteLine("\n---------------------");
        Console.WriteLine(msg);
        foreach (var item in tarefaz)
        {
            Console.WriteLine($"Task: {item.Key} - {item.Value}");
        }
    }
}












