using System.Reflection.Metadata;
using Microsoft.VisualBasic;

internal partial class Program
{
    static string mesg = "Digite um LOG:";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Organizer Log ]\n");
        GetInput();
    }
    static void ProcessarInput(string input)
    {
        Console.Clear();

        Console.WriteLine($"Data: {input.Split(',')[0]}");
        Console.WriteLine($"Tipo de erro: {input.Split(',')[1]}");
        Console.WriteLine($"Mensagem: {input.Split(',')[2]}");

        Console.WriteLine("FIM !");
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