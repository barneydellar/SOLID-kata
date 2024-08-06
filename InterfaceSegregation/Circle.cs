namespace InterfaceSegregation;

internal class Circle(int radius) : IShape
{
    public double Area()
    {
        return Math.Pow(radius, 2) * Math.PI;
    }

    public double Depth()
    {
        return 0;
    }

    public double Height()
    {
        return 0;
    }

    public double Radius()
    {
        return radius;
    }

    public double Volume()
    {
        throw new NotImplementedException();
    }

    public double Width()
    {
        return 0;
    }
}