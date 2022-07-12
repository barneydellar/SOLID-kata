using NUnit.Framework;

namespace Solid.Liskov
{
    internal class SquareTest
    {
        [TestCase]
        public void SquaresCanBeCreated()
        {
            var s = new Square();
        }

        [TestCase]
        public void SquaresHaveNoSizeAtStartup()
        {
            var s = new Square();
            Assert.AreEqual(0, s.GetWidth());
            Assert.AreEqual(0, s.GetHeight());
        }

        [TestCase]
        public void SquaresHaveNoAreaAtStartup()
        {
            var s = new Square();
            Assert.AreEqual(0, s.Area);
        }

        [TestCase]
        public void CanSetTheWidthOfSquares()
        {
            var s = new Square();
            s.SetWidth(10);
            Assert.AreEqual(10, s.GetWidth());
            Assert.AreEqual(10, s.GetHeight());
        }

        [TestCase]
        public void CanSetTheHeightOfSquares()
        {
            var s = new Square();
            s.SetHeight(20);
            Assert.AreEqual(20, s.GetWidth());
            Assert.AreEqual(20, s.GetHeight());
        }

        [TestCase]
        public void SquaresHaveAreaOfWidthByWidth()
        {
            var s = new Square();
            s.SetHeight(20);
            s.SetWidth(10);
            Assert.AreEqual(10 * 10, s.Area);
        }

        [TestCase]
        public void SquaresHaveAreaOfHeightByHeight()
        {
            var s = new Square();
            s.SetWidth(10);
            s.SetHeight(20);
            Assert.AreEqual(20 * 20, s.Area);
        }
    }
}
