using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation
{
    class CircleTest
    {
        [TestCase]
        public void CirclesCanBeCreated()
        {
            Shape s = new Circle(5);
        }

        [TestCase]
        public void CirclesHaveARadius()
        {
            Shape s = new Circle(5);
            Assert.AreEqual(5, s.Radius());
        }

        [TestCase]
        public void CirclesHaveArea()
        {
            Shape s = new Circle(5);
            Assert.AreEqual(5 * 5 * Math.PI, s.Area());
        }
    }
}
