﻿using NUnit.Framework;

namespace Solid.InterfaceSegregation
{
    class CuboidTest
    {
        [TestCase]
        public void CuboidCanBeCreated()
        {
            Shape s = new Cuboid(2, 3, 4);
        }

        [TestCase]
        public void CuboidsHaveWidthDepthAndHeight()
        {
            Shape s = new Cuboid(2, 3, 4);
            Assert.AreEqual(2, s.Width());
            Assert.AreEqual(3, s.Height());
            Assert.AreEqual(4, s.Depth());
        }

        [TestCase]
        public void CuboidsHaveVolume()
        {
            Shape s = new Cuboid(2, 3, 4);
            Assert.AreEqual(2 * 3 * 4, s.Volume());
        }

        [TestCase]
        public void CuboidsHaveArea()
        {
            Shape s = new Cuboid(2, 3, 4);
            double expectedArea = 2 * ((2 * 3) + (2 * 4) + (3 * 4));
            Assert.AreEqual(expectedArea, s.Area());
        }
    }
}
