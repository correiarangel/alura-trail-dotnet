namespace Geometria.Shapes; 
internal class Circle(double radius) : GeometricShape
{
    public double Radius { get; } = radius;

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override GeometricShape CreateShape()
    {
        Console.Write("Informe o raio: ");
        double raio = double.Parse(Console.ReadLine()??"0");
        return new Circle(raio);
    }

}