using NUnit.Framework;

namespace Solid.InterfaceSegregation
{
    class SquareTest
    {
        [TestCase]
        public void SquaresCanBeCreated()
        {
            Shape s = new Square(2, 3);
        }

        [TestCase]
        public void SquaresHaveWidthAndHeight()
        {
            Shape s = new Square(2, 3);
            Assert.AreEqual(2, s.Width());
            Assert.AreEqual(3, s.Height());
        }

        [TestCase]
        public void SquaresHaveArea()
        {
            Shape s = new Square(2, 3);
            Assert.AreEqual(6, s.Area());
        }
    }
}
