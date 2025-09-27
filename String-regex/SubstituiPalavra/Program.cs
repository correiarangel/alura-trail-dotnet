internal partial class Program
{
    static string fraseCorrente = "Programando em Flutter";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Troca Palavra ]\n");
        Console.WriteLine($"Frase corrente {fraseCorrente}\n");
        var palavraAntiga = GetInput("Qual palavra quer mudar ?");
        var palavraNova = GetInput("Por qaul palavra ?");
        ProcessarInput(palavraAntiga,palavraNova);
        
    }
    static void ProcessarInput(string palavraAntiga,string palavraNova)
    {
        var novaFrase = fraseCorrente.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"Frase alterada:\n {novaFrase}\n");
    }

    static string GetInput(string mesg)
    {
        while (true)
        {
            Console.WriteLine(mesg);
            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            Console.WriteLine($"Invalido!\n");
        }
    }

}