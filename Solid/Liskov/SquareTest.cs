using NUnit.Framework;

namespace Solid.Liskov
{
    class SquareTest
    {
        [TestCase]
        public void SquaresCanBeCreated()
        {
            Square s = new Square();
        }

        [TestCase]
        public void SquaresHaveNoSizeAtStartup()
        {
            Square s = new Square();
            Assert.AreEqual(0, s.GetWidth());
            Assert.AreEqual(0, s.GetHeight());
        }

        [TestCase]
        public void SquaresHaveNoAreaAtStartup()
        {
            Square s = new Square();
            Assert.AreEqual(0, s.Area);
        }

        [TestCase]
        public void ICanSetTheWidthOfSquares()
        {
            Square s = new Square();
            s.SetWidth(10);
            Assert.AreEqual(10, s.GetWidth());
            Assert.AreEqual(10, s.GetHeight());
        }

        [TestCase]
        public void ICanSetTheHeightOfSquares()
        {
            Square s = new Square();
            s.SetHeight(20);
            Assert.AreEqual(20, s.GetWidth());
            Assert.AreEqual(20, s.GetHeight());
        }

        [TestCase]
        public void SquaresHaveAreaOfWidthByWidth()
        {
            Square s = new Square();
            s.SetHeight(20);
            s.SetWidth(10);
            Assert.AreEqual(10 * 10, s.Area);
        }

        [TestCase]
        public void SquaresHaveAreaOfHeightByHeight()
        {
            Square s = new Square();
            s.SetWidth(10);
            s.SetHeight(20);
            Assert.AreEqual(20 * 20, s.Area);
        }
    }
}
