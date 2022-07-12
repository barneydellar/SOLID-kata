using NUnit.Framework;

namespace Solid.InterfaceSegregation;

internal class RectangleTest
{
    [Test]
    public void RectanglesCanBeCreated()
    {
        IShape s = new Rectangle(2, 3);
    }

    [Test]
    public void RectanglesHaveWidthAndHeight()
    {
        IShape s = new Rectangle(2, 3);
        Assert.AreEqual(2, s.Width());
        Assert.AreEqual(3, s.Height());
    }

    [Test]
    public void RectanglesHaveArea()
    {
        IShape s = new Rectangle(2, 3);
        Assert.AreEqual(6, s.Area());
    }
}