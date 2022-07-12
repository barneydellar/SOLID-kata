using NUnit.Framework;

namespace Solid.InterfaceSegregation
{
    internal class RectangleTest
    {
        [TestCase]
        public void RectanglesCanBeCreated()
        {
            IShape s = new Rectangle(2, 3);
        }

        [TestCase]
        public void RectanglesHaveWidthAndHeight()
        {
            IShape s = new Rectangle(2, 3);
            Assert.AreEqual(2, s.Width());
            Assert.AreEqual(3, s.Height());
        }

        [TestCase]
        public void RectanglesHaveArea()
        {
            IShape s = new Rectangle(2, 3);
            Assert.AreEqual(6, s.Area());
        }
    }
}
