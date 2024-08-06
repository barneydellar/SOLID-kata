using NUnit.Framework;

namespace InterfaceSegregation;

internal class CuboidTest
{
    [Test]
    public void CuboidCanBeCreated()
    {
        IShape s = new Cuboid(2, 3, 4);
    }

    [Test]
    public void CuboidsHaveWidthDepthAndHeight()
    {
        IShape s = new Cuboid(2, 3, 4);
        Assert.That(s.Width(), Is.EqualTo(2));
        Assert.That(s.Height(), Is.EqualTo(3));
        Assert.That(s.Depth(), Is.EqualTo(4));
    }

    [Test]
    public void CuboidsHaveVolume()
    {
        IShape s = new Cuboid(2, 3, 4);
        Assert.That(s.Volume(), Is.EqualTo(2 * 3 * 4));
    }

    [Test]
    public void CuboidsHaveArea()
    {
        IShape s = new Cuboid(2, 3, 4);
        double expectedArea = 2 * ((2 * 3) + (2 * 4) + (3 * 4));
        Assert.That(s.Area(), Is.EqualTo(expectedArea));
    }
}