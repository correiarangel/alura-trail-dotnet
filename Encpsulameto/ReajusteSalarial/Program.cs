
internal partial class Program
{
    static Funcionario funcionario = new Funcionario("Fernanda Lima", 4000);

    private static void Main(string[] args)
    {
        Console.WriteLine("\r$$$ Rajuste de salário $$$\n");
        bool isDeposito = IsDeposito("Use [N] para reajustar o salario [S] para sair !");


        if (isDeposito)
        {
            EventoReajuste();
        }

        if (!isDeposito)
        {
            Console.WriteLine("Sistema  finalizado !....");
        }

    }

    static void EventoReajuste()
    {
        var salario = funcionario.Salario;
        Console.WriteLine($"\nReajuste salarial | Salario Atual: {salario.ToString("F2")}\n");
        salario = GetInput("Digite o valor do reajuste: ");
        funcionario.ReajustarSalario(salario);
    }

    static bool IsDeposito(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();


            if (string.IsNullOrEmpty(input) && input == "N" || input == "n")
            {
                return true;
            }
            if (string.IsNullOrEmpty(input) && input == "S" || input == "s")
            {
                return false;
            }
            Console.WriteLine("Valor invalido use [N] para reajuste [S] para sair !....");

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


















