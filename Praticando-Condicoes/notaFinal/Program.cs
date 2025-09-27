// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static double saldo = 190.34;
    static string mesg = "Use numeros de [0 a 9, e virgula [,] para decimal] para nota final";
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nClassificação de Nota final\n");
        int nota = GetInput(mesg);

        TesteNotaFinal(nota);

    }

    static void TesteNotaFinal(int nota)
    {

        if (nota < 5)
        {
            Console.WriteLine($"Classificação final [D] sua nota {nota}");
            return;
        }
        if (nota >= 5 && nota < 7)
        {
            Console.WriteLine($"Classificação final [C] sua nota {nota}");
            return;
        }
        if (nota >= 7 && nota < 9)
        {
            Console.WriteLine($"Classificação final [B] sua nota {nota}");
            return;
        }
        if (nota >= 9)
        {
            Console.WriteLine($"Classificação final [A] sua nota {nota}");
            return;
        }
        Console.WriteLine("Valor invalido ou algo deu errado valor não foi reconhecido reinicie e siga as intruções....");
    }
    static int GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (int.TryParse(inputFilter, out int real))
            {
                return real;
            }
            Console.WriteLine($"Valor invalido use {mesg}");

        }
    }


}