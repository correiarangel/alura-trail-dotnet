
using System.Threading.Tasks;

internal partial class Program
{
    static Dictionary<string,decimal>notas = new Dictionary<string,decimal>();
    private static void Main(string[] args)
    {
        Console.WriteLine("\nNotas");
        AddNotas();
        ListsNotas();
    }

    static async void AddNotas()
    {
        Console.WriteLine("\nNotas Adicionandas .......");
        notas.Add("Ana", 8.75m);
        notas.Add("Bruno", 6.90m);
        notas.Add("Clara", 9.25m);
        notas.Add("Zé Colmeia", 5.75m);
        notas.Add("Catatal", 7.90m);
        notas.Add("Snop", 10.00m);
        notas.Add("Tião Galinha", 3.75m);
        notas.Add("Batman", 6.20m);
        notas.Add("Lanterna verde", 9.25m);
    }

    static async void ListsNotas()
    {
        Console.WriteLine("\nLista de notas");
        //KeyValuePair<string, decimal>
        foreach (var aluno in notas)
        {
            Console.WriteLine($"Aluno: {aluno.Key} - Nota: {aluno.Value}");
        }
    }
}
