using System.Reflection.Metadata;
using Microsoft.VisualBasic;


internal partial class Program
{
    static string mesg = "Digite um Alerta:";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\n[ Dispara Alerta ]\n");
        string nome = GetInput("Digite o nome do cliente:");
        string endereco = GetInput("Digite o endereço:");
        Console.WriteLine("Digite o valor do frete:");
        double frete = double.Parse(Console.ReadLine());
        string data = GetInput("Digite a data de entrega:");

        ProcessarInput(nome, endereco, data, frete);    
    }
    static void ProcessarInput(string nome, string endereco, string data, double frete)
    {
        Console.Clear();
        Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
        Console.WriteLine($"Cliente:\t \"{nome}\"");
        Console.WriteLine($"Endereço:\t \"{endereco}\"");
        Console.WriteLine($"Valor do frete: R$ {frete.ToString("0.00")}");
        Console.WriteLine($"Data:\t\t {data}\n");
        Console.WriteLine("=========================================="); Console.WriteLine("\nFIM !\n");
        return;
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
            Console.WriteLine($"Invalido !\n");
        }
    }

}
