
using System.Threading.Tasks;

internal partial class Program
{
    static int TotalVendas = 0;
    static List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };
    static List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };
    private static void Main(string[] args)
    {
        Console.WriteLine("\nProdutos");
        CurrentLists();
        SecudaryLists();
        JoinLists();
    }

    static async void CurrentLists()
    {
        Console.WriteLine("\nLista atual:");

        foreach (var item in produtosPrincipal)
        {
            Console.WriteLine(item);

        }
    }
    static async void SecudaryLists()
    {
        Console.WriteLine("\nLista secundaria:");

        foreach (var item in produtosSecundaria)
        {
            Console.WriteLine(item);

        }
    }

    static async void JoinLists()
    {
        Console.WriteLine("\nLista inificadas");
        foreach (var p in produtosSecundaria)
        {
            produtosPrincipal.Add(p);
        }
        produtosPrincipal.ForEach(Console.WriteLine);
    }
}
