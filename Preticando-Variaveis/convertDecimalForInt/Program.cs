
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n TRANSPORTE FELIZ \n");
        Console.WriteLine("\n Calcula a qautidade de veiculos para transporta mercadoria: USE NUMEROS !\n");

        decimal pesoTotal = GetInput("Digite o total de carga em kilos:");
        CalcQuantosVeiculos(pesoTotal);
    }

    private static void CalcQuantosVeiculos(decimal pesoTotal)
    {
        int qtVeiculos = (int)pesoTotal;
        Console.WriteLine($"Você precisa de {qtVeiculos} veiculos pequenos ou medios para entraga!");
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
            Console.WriteLine("Valor invalido !....$##@*(&@)");

        }
    }

}
