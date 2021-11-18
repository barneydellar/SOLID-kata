using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation
{
    class SphereTest
    {
        [TestCase]
        public void SpheresCanBeCreated()
        {
            Shape s = new Sphere(5);
        }

        [TestCase]
        public void SpheresHaveARadius()
        {
            Shape s = new Sphere(5);
            Assert.AreEqual(5, s.Radius());
        }

        [TestCase]
        public void SpheresHaveVolume()
        {
            Shape s = new Sphere(5);
            Assert.AreEqual(5 * 5 * 5 * 4 * Math.PI / 3, s.Volume());
        }

        [TestCase]
        public void SpheresHaveArea()
        {
            Shape s = new Sphere(5);
            Assert.AreEqual(5 * 5 * 4 * Math.PI, s.Area());
        }
    }
}
