using NUnit.Framework;

namespace InterfaceSegregation;

internal class RectangleTest
{
    [Test]
    public void RectanglesCanBeCreated()
    {
        _ = new Rectangle(2, 3);
    }

    [Test]
    public void RectanglesHaveWidthAndHeight()
    {
        IShape s = new Rectangle(2, 3);
        Assert.That(s.Width(), Is.EqualTo(2));
        Assert.That(s.Height(), Is.EqualTo(3));
    }

    [Test]
    public void RectanglesHaveArea()
    {
        IShape s = new Rectangle(2, 3);
        Assert.That(s.Area(), Is.EqualTo(6));
    }
}