using Microsoft.VisualBasic;

internal partial class Program
{

    private static void Main(string[] args)
    {
        var bankAccount = new BankAccount("123456", 1000);
        Console.WriteLine("\nBanco BOM Bank \nConsulte seu saldo: USE NUMEROS !\n");
        bool isDeposito = IsDeposito("Use [D] para depsito e [S] para saque!");

        if (isDeposito)
        {
            EventoDeposito(bankAccount);
        }

        if (!isDeposito)
        {
            EventoSaque(bankAccount);
        }

    }

    static void EventoDeposito(BankAccount account)
    {

        Console.WriteLine($"\nDeposito: \n");
        account.ViewBalance();

        var input = GetInput("Digite o valor do deposido: ");
        account.Deposit(input);
        if (account.Balance < 0)
        {
            Console.WriteLine($"ATENÇÂO -> Saldo após deposito NEGATIVO {account.Balance}");
            return;
        }
        Console.WriteLine($"Saldo após deposito ");
        account.ViewBalance();
    }


    static void EventoSaque(BankAccount account)
    {
        Console.WriteLine($"\nSaque: \n");
        account.ViewBalance();

        var valorSaque = GetInput("Digite o valor do saque: ");

        if (account.Balance < 0 || valorSaque > account.Balance)
        {
            Console.WriteLine($"ATENÇÂO -> Saldo insuficiente para valolor {valorSaque.ToString("F2")}\nSaldo Atual: {account.Balance}");
            return;
        }

        account.Sake(valorSaque);

        Console.WriteLine($"Saldo após saque: ");
        account.ViewBalance();
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
    static decimal GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c) || c == '.' || c == ',')]);

            if (decimal.TryParse(inputFilter, out decimal real))
            {
                return real;
            }
            Console.WriteLine("Valor invalido !....");

        }
    }


}