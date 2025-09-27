using System.Net.NetworkInformation;

internal partial class Program
{
    static double pi = 3.14159;
    private static void Main(string[] args)
    {
        Console.WriteLine("Calcula Área e Perimetro de um Circulo : USE NUMEROS !\n");

        double raio = GetInput("Digite o raio : ");
        CalcularArea(raio);
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
    static void CalcularArea(double raio)
    {
        double area = pi * raio * raio;
        double perimetro = 2 * pi * raio;
        Console.WriteLine($"\n---------------------------------");
         Console.WriteLine($"RESULTADOS \n");
        Console.WriteLine($"Raio circulo :{raio.ToString("F2")}.");
        Console.WriteLine($"A área do circulo :{area.ToString("F2")}");
        Console.WriteLine($"A área do perimetro :{perimetro.ToString("F2")}");
        Console.WriteLine($"---------------------------------\n");

    }

}