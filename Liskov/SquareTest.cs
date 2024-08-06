using NUnit.Framework;

namespace Liskov;

internal class SquareTest
{
    [Test]
    public void SquaresCanBeCreated()
    {
        _ = new Square();
    }

    [Test]
    public void SquaresHaveNoSizeAtStartup()
    {
        var s = new Square();
        Assert.That(s.GetWidth(), Is.EqualTo(0));
        Assert.That(s.GetHeight(), Is.EqualTo(0));
    }

    [Test]
    public void SquaresHaveNoAreaAtStartup()
    {
        var s = new Square();
        Assert.That(s.Area, Is.EqualTo(0));
    }

    [Test]
    public void CanSetTheWidthOfSquares()
    {
        var s = new Square();
        s.SetWidth(10);
        Assert.That(s.GetWidth(), Is.EqualTo(10));
        Assert.That(s.GetHeight(), Is.EqualTo(10));
    }

    [Test]
    public void CanSetTheHeightOfSquares()
    {
        var s = new Square();
        s.SetHeight(20);
        Assert.That(s.GetWidth(), Is.EqualTo(20));
        Assert.That(s.GetHeight(), Is.EqualTo(20));
    }

    [Test]
    public void SquaresHaveAreaOfWidthByWidth()
    {
        var s = new Square();
        s.SetHeight(20);
        s.SetWidth(10);
        Assert.That(s.Area, Is.EqualTo(10 * 10));
    }

    [Test]
    public void SquaresHaveAreaOfHeightByHeight()
    {
        var s = new Square();
        s.SetWidth(10);
        s.SetHeight(20);
        Assert.That(s.Area, Is.EqualTo(20 * 20));
    }
}