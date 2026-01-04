namespace Geometria.Shapes;
internal class Rectangle(double width, double height) : GeometricShape
{
    public double Width { get; } = width;
    public double Height { get; } = height;

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
    public override GeometricShape CreateShape()
    {
        Console.Write("Informe a largura: ");
        double largura = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Informe a altura: ");
        double altura = double.Parse(Console.ReadLine() ?? "0");
        return new Rectangle(largura, altura);
    }
}