
using System.Threading.Tasks;

internal partial class Program
{
    static Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" },
            { 4, "Faca" },
            { 5, "Martelo" },
        };
    private static void Main(string[] args)
    {
        Console.WriteLine("\nInventatio Games");
        ListInventario("Lista de  inventário");;
        Add();
        Remove();
        ListInventario("Lista de  inventário atulisada");
    }

    static async void Add()
    {
        Console.WriteLine("\nVida Adicionandas .......");
        inventario.Add(6, "Poção de Vida");
    }
    static async void Remove()
    {

        Console.WriteLine($"\nRemovendo -> {inventario[2]} .........");
        inventario.Remove(2);

    }

    static async void ListInventario(string msg)
    {
        Console.WriteLine("\n---------------------");
        Console.WriteLine(msg);
        foreach (var item in inventario)
        {
            Console.WriteLine($"ID: {item.Key} - {item.Value}");
        }
    }
}












