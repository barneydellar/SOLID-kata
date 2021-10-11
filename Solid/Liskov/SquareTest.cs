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
            Assert.AreEqual(0, s.Width);
            Assert.AreEqual(0, s.Height);
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
            s.Width = 10;
            Assert.AreEqual(10, s.Width);
            Assert.AreEqual(10, s.Height);
        }

        [TestCase]
        public void ICanSetTheHeightOfSquares()
        {
            Square s = new Square();
            s.Height = 20;
            Assert.AreEqual(20, s.Width);
            Assert.AreEqual(20, s.Height);
        }

        [TestCase]
        public void SquaresHaveAreaOfWidthByWidth()
        {
            Square s = new Square();
            s.Height = 20;
            s.Width = 10;
            Assert.AreEqual(10 * 10, s.Area);
        }

        [TestCase]
        public void SquaresHaveAreaOfHeightByHeight()
        {
            Square s = new Square();
            s.Width = 10;
            s.Height = 20;
            Assert.AreEqual(20 * 20, s.Area);
        }
    }
}
