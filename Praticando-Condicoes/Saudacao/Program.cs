// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static string mesg = "Use numeros [1|2|3]";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\nMomento dia\n");
        string nome = GetNomeInput();
        int moment = GetMomentInput("Digite o momento " + mesg);
        ProcessarInput(nome, moment);
    }
    static void ProcessarInput(string nome, int moment)
    {

        switch (moment)
        {
            case 1:
                Console.WriteLine($"Bom dia {nome} ....");
                break;
            case 2:
                Console.WriteLine($"Boa tarde {nome} ....");
                break;
            case 3:
                Console.WriteLine($"Boa noite {nome} ....");
                break;

            default:
                Console.WriteLine($"\nValor invalido para mometo use \n 1 - para manhã,\n 2 - para tarde,\n 3 - para noite,\n");
                break;
        }

    }
    static string GetNomeInput()
    {
        while (true)
        {
            Console.WriteLine("Digite seu nome !");
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }
            Console.WriteLine($"Valor invalido, para nome!");
        }
    }
    static int GetMomentInput(string msg)
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
            Console.WriteLine($"Valor invalido, {mesg}");
        }
    }
}