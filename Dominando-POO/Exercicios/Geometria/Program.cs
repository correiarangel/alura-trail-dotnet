using System;
using Geometria.Shapes;

Console.WriteLine("Sistema de formas geométricas");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Círculo");
    Console.WriteLine("2 - Quadrado");
    Console.WriteLine("3 - Retângulo");
    Console.WriteLine("4 - Pentágono");
    Console.WriteLine("0 - Sair");

    Console.Write("Opção: ");
    string choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("Encerrando o sistema.");
        break;
    }
    int defaultValue = 5;
    try
    {
        GeometricShape shape = choice switch
        {
            "1" => new Circle(defaultValue).CreateShape(),
            "2" => new Square(defaultValue).CreateShape(),
            "3" => new Rectangle(defaultValue, defaultValue).CreateShape(),
            "4" => new Pentagon(defaultValue).CreateShape(),
            "5"=> new Triangle(defaultValue,defaultValue,defaultValue,defaultValue,defaultValue).CreateShape(),
            "6"=> new Iquisagon(defaultValue).CreateShape(),
            _ => throw new InvalidOperationException("Opção inválida.")
        };

        Console.WriteLine($"Área: {shape.CalculateArea()}");
        Console.WriteLine($"Perímetro: {shape.CalculatePerimeter()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}


