using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


internal partial class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Remove espaços de string ]\n");
        string input = GetInput("Digite o texto :");
        var result = RemoveEspace(input);
        Console.WriteLine($"\nValor sem espaços extra:\n{result}\n");
    }
    static string RemoveEspace(string input)
    {
       var newInput = input.Replace("  ", "");  
        return newInput;
    }

    static string GetInput(string mesg)
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();


            if (!string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }
            Console.WriteLine($"Invalido  !\n");
        }

    }
}
