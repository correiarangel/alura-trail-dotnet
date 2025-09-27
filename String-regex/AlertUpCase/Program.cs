using System.Reflection.Metadata;
using Microsoft.VisualBasic;

internal partial class Program
{
    static string mesg = "Digite um Alerta:";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Dispara Alerta ]\n");
        GetInput();
    }
    static void ProcessarInput(string input)
    {
        Console.Clear();
        Console.WriteLine($"\n{input.ToUpper()}");
        Console.WriteLine("\nFIM !\n");
        return;
    }

    static void GetInput()
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                ProcessarInput(input);
                return;
            }
            Console.WriteLine($"Invalido !\n");
        }
    }

}
