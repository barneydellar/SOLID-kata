using NUnit.Framework;

namespace Solid.InterfaceSegregation
{
    class RectangleTest
    {
        [TestCase]
        public void RectanglesCanBeCreated()
        {
            Shape s = new Rectangle(2, 3);
        }

        [TestCase]
        public void RectanglesHaveWidthAndHeight()
        {
            Shape s = new Rectangle(2, 3);
            Assert.AreEqual(2, s.Width());
            Assert.AreEqual(3, s.Height());
        }

        [TestCase]
        public void RectanglesHaveArea()
        {
            Shape s = new Rectangle(2, 3);
            Assert.AreEqual(6, s.Area());
        }
    }
}
