namespace Geometria.Shapes;
internal class Triangle(double baseTriangulo, double altura, double ladoA, double ladoB, double ladoC) : GeometricShape
{
    public double Base { get; } = baseTriangulo;
    public double Altura { get; } = altura;
    public double LadoA { get; } = ladoA;
    public double LadoB { get; } = ladoB;
    public double LadoC { get; } = ladoC;

    public override double CalculateArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalculatePerimeter()
    {
        return LadoA + LadoB + LadoC;
    }

    public override GeometricShape CreateShape()
    {
        Console.Write("Informe a base do triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Informe a altura do triângulo: ");
        double altura = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Informe o lado A do triângulo: ");
        double ladoA = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Informe o lado B do triângulo: ");
        double ladoB = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Informe o lado C do triângulo: ");
        double ladoC = double.Parse(Console.ReadLine() ?? "0");

        return new Triangle(baseTriangulo, altura, ladoA, ladoB, ladoC);
    }
}