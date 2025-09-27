// See https://aka.ms/new-console-template for more information

internal partial class Program
{
    static double saldo = 190.34;
    private static void Main(string[] args)
    {
        Console.WriteLine("\nBanco BOM Bank \nConsulte seu saldo: USE NUMEROS !\n");
        bool isDeposito = IsDeposito("Use [D] para depsito e [S] para saque!");

        if (isDeposito)
        {
            EventoDeposito();
        }

        if (!isDeposito)
        {
            EventoSaque();
        }

    }

    static void EventoDeposito()
    {
        Console.WriteLine($"\nDeposito | Saldo Atual: {saldo.ToString("F2")}\n");
        saldo += GetInput("Digite o valor do deposido: ");
        if (saldo < 0)
        {
            Console.WriteLine($"ATENÇÂO -> Saldo após deposito NEGATIVO {saldo.ToString("F2")}");
            return;
        }
        Console.WriteLine($"Saldo após deposito {saldo}");
    }
    static void EventoSaque()
    {
        Console.WriteLine($"\nSaque | Saldo Atual: {saldo.ToString("F2")}\n");

        double valorSaque = GetInput("Digite o valor do Saque: ");
        if (saldo < 0 || valorSaque > saldo)
        {
            Console.WriteLine($"ATENÇÂO -> Saldo insuficiente para valolor {valorSaque.ToString("F2")}\nSaldo Atual: {saldo.ToString("F2")}");
            return;
        }
        saldo -= valorSaque;
        Console.WriteLine($"Saldo após deposito {saldo.ToString("F2")}");
    }
    static bool IsDeposito(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();


            if (string.IsNullOrEmpty(input) && input == "D" || input == "d")
            {
                return true;
            }
            if (string.IsNullOrEmpty(input) && input == "S" || input == "s")
            {
                return false;
            }
            Console.WriteLine("Valor invalido use [D] para depsito e [S] para saque!....");

        }
    }
    static double GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c) || c == '.' || c == ',')]);

            if (double.TryParse(inputFilter, out double real))
            {
                return real;
            }
            Console.WriteLine("Valor invalido !....");

        }
    }
    static void GetSaldo(double largura, double comprimento)
    {
        double area = largura * comprimento;
        Console.WriteLine($"A área do terreno é:{area}  metros quadrados.");

    }

}