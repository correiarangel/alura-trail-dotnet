namespace Geometria.Shapes;

internal class Pentagon(double sideLength) : GeometricShape
{
    public double SideLength { get; } = sideLength;

    public override double CalculateArea()
    {
        double apothem = SideLength / (2 * Math.Tan(Math.PI / 5));
        return (5 * SideLength * apothem) / 2;
    }

    public override double CalculatePerimeter()
    {
        return 5 * SideLength;
    }

    public override GeometricShape CreateShape()
    {
        Console.WriteLine("Digite o comprimento do lado do pentágono:");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        return new Pentagon(sideLength);
    }
}