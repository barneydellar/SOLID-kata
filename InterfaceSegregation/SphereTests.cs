using NUnit.Framework;

namespace InterfaceSegregation;

internal class SphereTest
{
    [Test]
    public void SpheresCanBeCreated()
    {
        IShape s = new Sphere(5);
    }

    [Test]
    public void SpheresHaveARadius()
    {
        IShape s = new Sphere(5);
        Assert.That(s.Radius(), Is.EqualTo(5));
    }

    [Test]
    public void SpheresHaveVolume()
    {
        IShape s = new Sphere(5);
        Assert.That(s.Volume(), Is.EqualTo(5 * 5 * 5 * 4 * Math.PI / 3));
    }

    [Test]
    public void SpheresHaveArea()
    {
        IShape s = new Sphere(5);
        Assert.That(s.Area(), Is.EqualTo(5 * 5 * 4 * Math.PI));
    }
}