namespace Geometria.Shapes;

internal class Iquisagon(double sideLength) : GeometricShape
{
    public double SideLength { get; } = sideLength;

    public override double CalculateArea()
    {
        double apothem = SideLength / (2 * Math.Tan(Math.PI / 6));
        return (6 * SideLength * apothem) / 2;
    }

    public override double CalculatePerimeter()
    {
        return 6 * SideLength;
    }

    public override GeometricShape CreateShape()
    {
        Console.WriteLine("Digite o comprimento do lado do equiságono:");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        return new Iquisagon(sideLength);
    }
}