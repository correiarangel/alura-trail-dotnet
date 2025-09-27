// See https://aka.ms/new-console-template for more information

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calcula Área: USE NUMEROS !\n");

        double largura = GetInput("Digite a largura:");
        double comprimento = GetInput("Digite o comprimeto:");
        CalcularArea(largura, comprimento);
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
    static void CalcularArea(double largura, double comprimento)
    {
        double area = largura * comprimento;
        Console.WriteLine($"A área do terreno é:{area}  metros quadrados.");

    }

}