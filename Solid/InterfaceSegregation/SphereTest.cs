using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation
{
    internal class CircleTest
    {
        [TestCase]
        public void CirclesCanBeCreated()
        {
            IShape s = new Circle(5);
        }

        [TestCase]
        public void CirclesHaveARadius()
        {
            IShape s = new Circle(5);
            Assert.AreEqual(5, s.Radius());
        }

        [TestCase]
        public void CirclesHaveArea()
        {
            IShape s = new Circle(5);
            Assert.AreEqual(5 * 5 * Math.PI, s.Area());
        }
    }
}
