using NUnit.Framework;

// Run the tests in the Test Explorer

namespace Solid.Liskov
{
    public class RectangleTest
    {
        [TestCase]
        public void RectanglesCanBeCreated()
        {
            Rectangle r = RectangleFactory.Create();
        }

        [TestCase]
        public void RectanglesHaveNoSizeAtStartup()
        {
            Rectangle r = RectangleFactory.Create();
            Assert.AreEqual(0, r.GetWidth());
            Assert.AreEqual(0, r.GetHeight());
        }

        [TestCase]
        public void RectanglesHaveNoAreaAtStartup()
        {
            Rectangle r = RectangleFactory.Create();
            Assert.AreEqual(0, r.Area);
        }

        [TestCase]
        public void ICanSetTheWidthAndHeightOfRectangles()
        {
            Rectangle r = RectangleFactory.Create();
            r.SetWidth(10);
            r.SetHeight(20);
            Assert.AreEqual(10, r.GetWidth());
            Assert.AreEqual(20, r.GetHeight());
        }

        [TestCase]
        public void RectanglesHaveAreaOfWidthByHeight()
        {
            Rectangle r = RectangleFactory.Create();
            r.SetWidth(10);
            r.SetHeight(20);
            Assert.AreEqual(10*20, r.Area);
        }

        //[TestCase]
        public void RectanglesStillHaveAreaOfWidthByHeight()
        {
            Rectangle r = RectangleFactory.Create2();
            r.SetWidth(10);
            r.SetHeight(20);
            Assert.AreEqual(10 * 20, r.Area);
        }
    }
}