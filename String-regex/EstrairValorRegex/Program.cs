using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


internal partial class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Estrair valor de string numerica de recibo ]\n");
        string input = GetInput("Digite o texto do recibo:");
        var result = GetValueNumber(input);
        Console.WriteLine($"\nValor encontrado: R$ {result}\n");
    }
    static string GetValueNumber(string input)
    {
        string pattern = @"\d+,\d{2}";
        var match = Regex.Match(input, pattern);
        
        return match.Success? match.Value : string.Empty;
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
