// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    const int SENHA = 123456;
    const int NIVEL = 6;
    static string mesg = "Use numeros de [0 a 9] para senha e nivel";
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nLogin {mesg}\n");
        int senha = GetInput("Ditete sua senaha:");
        int nivel = GetInput("Ditete nivel de acesso:");
        Login(senha, nivel);
    }

    static void Login(int senha, int nivel)
    {
        if (senha == SENHA && nivel == NIVEL)
        {
            Console.WriteLine($"Acesso Liberado!...");
            return;
        }
        Console.WriteLine("Acesso Negado !...");
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