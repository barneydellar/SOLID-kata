using NUnit.Framework;

// Run the tests in the Test Explorer

namespace Liskov;

public class RectangleTest
{
    [Test]
    public void RectanglesCanBeCreated()
    {
        _ = RectangleFactory.Create();
    }

    [Test]
    public void RectanglesHaveNoSizeAtStartup()
    {
        var r = RectangleFactory.Create();
        Assert.That(r.GetWidth(), Is.EqualTo(0));
        Assert.That(r.GetHeight(), Is.EqualTo(0));
    }

    [Test]
    public void RectanglesHaveNoAreaAtStartup()
    {
        var r = RectangleFactory.Create();
        Assert.That(r.Area, Is.EqualTo(0));
    }

    [Test]
    public void CanSetTheWidthAndHeightOfRectangles()
    {
        var r = RectangleFactory.Create();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.That(r.GetWidth(), Is.EqualTo(10));
        Assert.That(r.GetHeight(), Is.EqualTo(20));
    }

    [Test]
    public void RectanglesHaveAreaOfWidthByHeight()
    {
        var r = RectangleFactory.Create();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.That(r.Area, Is.EqualTo(10*20));
    }

    //[Test]
    public void RectanglesStillHaveAreaOfWidthByHeight()
    {
        var r = RectangleFactory.Create2();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.That(r.Area, Is.EqualTo(10 * 20));
    }
}