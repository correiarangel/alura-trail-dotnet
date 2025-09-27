using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

internal partial class Program
{
    static string[] arrayValues = new string[5];
    public static async Task Main(string[] args)
    {
        int soma = 0;

        Console.WriteLine("\n===DOAÇÃO SOMA ARRY ===\n");
        for (int i = 0; i < 5; i++)
        {
            var input = GetInput("Digite o valor da doação:");
            arrayValues[i] = input;
        }

        for (int i = 0; i < arrayValues.Length; i++)
        {
            soma += int.Parse(arrayValues[i]);
             Console.WriteLine($"\n{arrayValues[i]}\n");
        }
        Console.WriteLine($"\nTotal de doações:{soma} \n");
        return;
    }
    public static string GetInput(string msg)
    {
        Console.WriteLine(msg);
        string input = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrEmpty(input))
        {
            return input;
        }
        return "0";
    }
}
