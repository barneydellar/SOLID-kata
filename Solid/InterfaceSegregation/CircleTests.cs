using NUnit.Framework;
using System;

namespace Solid.InterfaceSegregation
{
    internal class SphereTest
    {
        [TestCase]
        public void SpheresCanBeCreated()
        {
            IShape s = new Sphere(5);
        }

        [TestCase]
        public void SpheresHaveARadius()
        {
            IShape s = new Sphere(5);
            Assert.AreEqual(5, s.Radius());
        }

        [TestCase]
        public void SpheresHaveVolume()
        {
            IShape s = new Sphere(5);
            Assert.AreEqual(5 * 5 * 5 * 4 * Math.PI / 3, s.Volume());
        }

        [TestCase]
        public void SpheresHaveArea()
        {
            IShape s = new Sphere(5);
            Assert.AreEqual(5 * 5 * 4 * Math.PI, s.Area());
        }
    }
}
