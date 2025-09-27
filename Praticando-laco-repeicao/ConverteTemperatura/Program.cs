using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

internal partial class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("\n=== CONVERSOR DE TEMPERATURA ===\n");
        GetInputMenu();
    }
    
    static void GetInputMenu()
    {
        string input = string.Empty;
            
            while (true)
            {
            string msg = "Escolha uma opção:\n 1 - Celsius para Fahrenheit \n 2 - Fahrenheit para Celsius \n 3 - Sair";
            input = GetInput(msg);                                  
            
            if (!string.IsNullOrEmpty(input))
            {
                if (input == "1")
                {
                    var temperatura = GetInputTemperatura("Celsius");
                    if (temperatura.HasValue)
                    {
                        double tempConvertida = ConvertTemp("1", temperatura.Value);
                        Console.WriteLine($"\n{temperatura.Value:F2}°C equivalem a {tempConvertida:F2}°F\n");
                    }
                }
                else if (input == "2")
                {
                    var temperatura = GetInputTemperatura("Fahrenheit");
                    if (temperatura.HasValue)
                    {
                        double tempConvertida = ConvertTemp("2", temperatura.Value);
                        Console.WriteLine($"\n{temperatura.Value:F2}°F equivalem a {tempConvertida:F2}°C\n");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("\nSistema finalizado...\n");
                    return;
                }
                else
                {
                    Console.WriteLine($"\nOpção inválida! {msg}\n");
                }
            }
        }
    }
    
    private static double ConvertTemp(string opcao, double temperatura)
    {
        switch (opcao)
        {
            case "1": // Celsius para Fahrenheit
                return (temperatura * 9.0 / 5.0) + 32;
                
            case "2": // Fahrenheit para Celsius
                return (temperatura - 32) * 5.0 / 9.0;
                
            default:
                throw new ArgumentException("Opção inválida para conversão");
        }
    }
    
    public static double? GetInputTemperatura(string unidade)
    {
        while (true)
        {
            Console.Write($"Digite a temperatura em {unidade}: ");
            string input = Console.ReadLine() ?? string.Empty;
            
            // Tentar converter para double, permitindo vírgula e ponto como separador decimal
            if (double.TryParse(input.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out double temperatura))
            {
                return temperatura;
            }
            else if (input.Equals("sair", StringComparison.OrdinalIgnoreCase))
            {
                return null; // Permite cancelar a operação
            }
            else
            {
                Console.WriteLine("Temperatura inválida! Digite um número válido ou 'sair' para cancelar.\n");
            }
        }
    }
    
    public static string GetInput(string msg)
    {
        Console.WriteLine("\n=== MENU DO SISTEMA ===\n");
        Console.WriteLine(msg);
        Console.Write("\nDigite sua opção: ");
        string input = Console.ReadLine() ?? string.Empty;
        return input.Trim();
    }
}
