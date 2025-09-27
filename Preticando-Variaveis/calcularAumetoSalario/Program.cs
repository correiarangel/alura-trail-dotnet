internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Calcula aumeto salario com base em percentual: USE NUMEROS !\n");

        decimal atualSalario = GetInput("Digite o Salario atual:");
        decimal aumetoPercentual = GetInput("Digiteo aumeto percentual:");

        CalcularAumeto(atualSalario, aumetoPercentual);
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
    static void CalcularAumeto(decimal salario, decimal aumeto )
    {
                           
        var novoSalario = salario + (salario*aumeto / 100);
        Console.WriteLine($"\n Novo Salario :{novoSalario.ToString("F2")} \n");
    }

}