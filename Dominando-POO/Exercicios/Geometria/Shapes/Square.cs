namespace Geometria.Shapes;
internal class Square(double sideLength) : GeometricShape
{
    public double SideLength { get; } = sideLength;

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }

    public override double CalculatePerimeter()
    {
        return 4 * SideLength;
    }

    public override GeometricShape CreateShape()
    {
        Console.WriteLine("Digite o comprimento do lado do quadrado:");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        return new Square(sideLength);
    }
}