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
            Assert.AreEqual(0, r.Width);
            Assert.AreEqual(0, r.Height);
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
            r.Width = 10;
            r.Height = 20;
            Assert.AreEqual(10, r.Width);
            Assert.AreEqual(20, r.Height);
        }

        [TestCase]
        public void RectanglesHaveAreaOfWidthByHeight()
        {
            Rectangle r = RectangleFactory.Create();
            r.Width = 10;
            r.Height = 20;
            Assert.AreEqual(10*20, r.Area);
        }

        //[TestCase]
        public void RectanglesStillHaveAreaOfWidthByHeight()
        {
            Rectangle r = RectangleFactory.Create2();
            r.Width = 10;
            r.Height = 20;
            Assert.AreEqual(10 * 20, r.Area);
        }
    }
}