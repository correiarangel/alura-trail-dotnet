// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using Microsoft.VisualBasic;

internal partial class Program
{
    static string mesg = "Digite uma fraze com a palavra chave:";
    const string palavraChave = "cavalo";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Palavra chave ]\n");
        GetInput();
        
    }
    static void ProcessarInput(string input)
    {

        if (input.Contains(palavraChave,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("A palavra-chave foi encontrada na pesquisa!");
            return;
        }
        Console.Clear();
        Console.WriteLine("A palavra-chave não foi encontrada !");
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
            Console.WriteLine($"Não encontrada!\n");
        }
    }

}