using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


internal partial class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Valida string numerica ]\n");
        string input = GetInput("Digite o código do cupom:");
        Console.WriteLine($"\nO Codigo {input} é valido \n");
    }
    static bool ValidInputNumber(string input)
    {
        string patter = @"^[0-9]+$";
        return Regex.IsMatch(input, patter);
    }

    static string GetInput(string mesg)
    {
        bool valid = false;
        while (!valid)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();
            valid = ValidInputNumber(input ?? string.Empty);

            if (valid)
            {
                return input ?? string.Empty;
            }
            Console.WriteLine($"Invalido use somete numeros de 1..9 !\n");
        }
        return string.Empty;
    }
}
