using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation;

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
        Assert.AreEqual(5, s.Radius());
    }

    [Test]
    public void SpheresHaveVolume()
    {
        IShape s = new Sphere(5);
        Assert.AreEqual(5 * 5 * 5 * 4 * Math.PI / 3, s.Volume());
    }

    [Test]
    public void SpheresHaveArea()
    {
        IShape s = new Sphere(5);
        Assert.AreEqual(5 * 5 * 4 * Math.PI, s.Area());
    }
}