using NUnit.Framework;

// Run the tests in the Test Explorer

namespace Solid.Liskov;

public class RectangleTest
{
    [Test]
    public void RectanglesCanBeCreated()
    {
        var r = RectangleFactory.Create();
    }

    [Test]
    public void RectanglesHaveNoSizeAtStartup()
    {
        var r = RectangleFactory.Create();
        Assert.AreEqual(0, r.GetWidth());
        Assert.AreEqual(0, r.GetHeight());
    }

    [Test]
    public void RectanglesHaveNoAreaAtStartup()
    {
        var r = RectangleFactory.Create();
        Assert.AreEqual(0, r.Area);
    }

    [Test]
    public void CanSetTheWidthAndHeightOfRectangles()
    {
        var r = RectangleFactory.Create();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.AreEqual(10, r.GetWidth());
        Assert.AreEqual(20, r.GetHeight());
    }

    [Test]
    public void RectanglesHaveAreaOfWidthByHeight()
    {
        var r = RectangleFactory.Create();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.AreEqual(10*20, r.Area);
    }

    //[Test]
    public void RectanglesStillHaveAreaOfWidthByHeight()
    {
        var r = RectangleFactory.Create2();
        r.SetWidth(10);
        r.SetHeight(20);
        Assert.AreEqual(10 * 20, r.Area);
    }
}