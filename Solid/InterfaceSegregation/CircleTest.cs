using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation;

internal class CircleTest
{
    [Test]
    public void CirclesCanBeCreated()
    {
        IShape s = new Circle(5);
    }

    [Test]
    public void CirclesHaveARadius()
    {
        IShape s = new Circle(5);
        Assert.That(s.Radius(), Is.EqualTo(5));
    }

    [Test]
    public void CirclesHaveArea()
    {
        IShape s = new Circle(5);
        Assert.That(s.Area(), Is.EqualTo(5 * 5 * Math.PI));
    }
}