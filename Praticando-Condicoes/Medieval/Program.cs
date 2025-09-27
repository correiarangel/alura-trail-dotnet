// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static string mesg = "Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL)";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\nMedieval games fast....\n");
        string cupom = GetInput();
        cupom = ProcessCupom(cupom);

        Console.WriteLine(cupom);
    }
    static string ProcessCupom(string input)
    {
        return input switch
        {
            "DOBRAR" => "Ganhar 2x EXP por 1 hora.",
            "CURAR" => "Poção de cura. liberada",
            "OURO" => "1000 moedas de ouro liberadas",
            "ESPECIAL" => "Item lendário liberado!",
            _ => "Cupom invalido ! ...",
        };
    }

    static string GetInput()
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input ?? string.Empty;
            }
            Console.WriteLine($"Valor invalido, para cupom!");
        }
    }

}