using System;

namespace Solid.InterfaceSegregation;

internal class Rectangle : IShape
{
    private readonly int _width;
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

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
        return _height;
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
        return _width;
    }
}