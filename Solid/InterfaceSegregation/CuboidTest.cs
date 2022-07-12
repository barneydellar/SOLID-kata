using NUnit.Framework;

namespace Solid.InterfaceSegregation;

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
        Assert.AreEqual(2, s.Width());
        Assert.AreEqual(3, s.Height());
        Assert.AreEqual(4, s.Depth());
    }

    [Test]
    public void CuboidsHaveVolume()
    {
        IShape s = new Cuboid(2, 3, 4);
        Assert.AreEqual(2 * 3 * 4, s.Volume());
    }

    [Test]
    public void CuboidsHaveArea()
    {
        IShape s = new Cuboid(2, 3, 4);
        double expectedArea = 2 * ((2 * 3) + (2 * 4) + (3 * 4));
        Assert.AreEqual(expectedArea, s.Area());
    }
}