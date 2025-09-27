// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

internal partial class Program
{
    static string mesg = "Use numeros de [0 a 9]";

    private static void Main(string[] args)
    {
        Console.WriteLine($"\nCalculadora com switch\n");
        double valor1 = GetInput("Digite o valor 1 " + mesg);
        double valor2 = GetInput("Digite o valor 2 " + mesg);
        string operador = GetOperadoInput("Digite o operador use /,*,+,- ");
        Calculalar(valor1, valor2, operador);


    }

    static void Calculalar(double valor1, double valor2, string operador)
    {

        switch (operador)
        {
            case "+":
                Console.WriteLine($"A Soma dos valores é iqual {valor1 + valor2} ....");
                break;
            case "-":
                Console.WriteLine($"A Subtração dos valores é iqual {valor1 - valor2} ....");
                break;
            case "/":
                Console.WriteLine($"A Divisão dos valores é iqual {valor1 / valor2} ....");
                break;
            case "*":
                Console.WriteLine($"A Multiplicação dos valores é iqual {valor1 * valor2} ....");
                break;
            default:
                Console.WriteLine($"\nA Oprerador desconhecido use:\n / para divisão,\n * para multiplicação,\n - para subtração,\n + para suma.");
                break;
        }

    }
    static double GetInput(string msg)
    {
        while (true)
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();

            string inputFilter = new([.. input.Where(c => char.IsDigit(c))]);

            if (double.TryParse(inputFilter, out double real))
            {
                return real;
            }
            Console.WriteLine($"Valor invalido, {mesg}");

        }
    }
    static string GetOperadoInput(string msg)
    {
        string operador = "?";
        while (operador == "?")
        {
            Console.WriteLine(msg);
            string? input = Console.ReadLine();
            return input switch
            {
                "-" => operador = "-",
                "+" => operador = "+",
                "/" => operador = "/",
                "*" => operador = "*",
                _ => operador = "?",
            };
        }
        return operador;
    }

}