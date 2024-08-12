namespace InterfaceSegregation;

internal class Rectangle(int width, int height) : IShape
{
    public double Area()
    {
        return Width() * Height();
    }

    public double Depth()
    {
        return 0;
    }

    public double Height()
    {
        return height;
    }

    public double Radius()
    {
        throw new NotImplementedException();
    }

    public double Volume()
    {
        return Width() * Height() * Depth();
    }

    public double Width()
    {
        return width;
    }
}