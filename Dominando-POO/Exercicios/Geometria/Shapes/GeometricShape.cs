namespace Geometria.Shapes;

internal class GeometricShape
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }

    public virtual GeometricShape CreateShape()
    {
        return new GeometricShape();
    }
}