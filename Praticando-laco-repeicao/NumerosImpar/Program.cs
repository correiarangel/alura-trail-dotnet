
using System.IO.Compression;
using System.Threading.Tasks;


internal partial class Program
{
    static List<double> ListNumbers = new List<double>();

    public static async Task Main(string[] args)
    {
        GetInputMenu();
    }


    static void MostraNumeroImpar()
    {
        List<double> Numbers = new List<double>();

        if (ListNumbers.Any())
        {
            foreach (var numero in ListNumbers)
            {
                if (numero % 2 != 0)
                {
                    Numbers.Add(numero);
                    Console.WriteLine($"{numero} e Impar !...");
                }
            }
             Console.WriteLine($"\nA lista possui {Numbers.Count} numeros  Impar !...");
        }
    }
    static void GetInputMenu()
    {
        string input = string.Empty;

        while (true)
        {
            string msg = "\nEscolha uma opção:\n 1 - Adicinar numero \n 2 - Verlista de numero impars \n 3 - Sair";
            input = GetInput(msg);
            if (!string.IsNullOrEmpty(input))
            {
                if (input == "1")
                {
                    InputNumero();
                }
                else if (input == "2")
                {
                    MostraNumeroImpar();
                }
                else if (input == "3")
                {
                    Console.WriteLine("\nSitema finalizado........\n");
                    return;
                }
                else
                {
                    Console.WriteLine($"\nInvalido digite->\n1 - Gerar nova senha \n2 - Chamar próxima senha \n3 - Sair");
                }
            }
        }

    }

public static void InputNumero()
    {
        while (true)
        {
            Console.WriteLine("\nDigite um numero ou [s] para voltar");
            string input = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrEmpty(input))
            {
                if (input == "s")
                {
                     return;
                }
                ListNumbers.Add(int.Parse(input));
                Console.WriteLine($"\nNumero: {input} adicionado a lista...");
            }
        }
    }
    public static string GetInput(string msg)
    {
        Console.WriteLine(msg);
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }
}



