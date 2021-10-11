using NUnit.Framework;
using System;

namespace Solid.SingleResponsibility
{
    class AreaCalculatorTest
    {
        [TestCase]
        public void AreaCalculatorsCanBeCreated()
        {
            AreaCalculator calculator = new AreaCalculator(new object[] { });
        }

        [TestCase(5, 10)]
        [TestCase(2, 3)]
        public void RectanglesCanHaveTheirAreaCalculated(int w, int h)
        {
            AreaCalculator calculator = new AreaCalculator(new object[] { new Rectangle(w, h) });

            var output = calculator.Areas();

            Assert.AreEqual("Rectangle: " + (w*h).ToString(), output);
        }

        [TestCase(5)]
        [TestCase(7)]
        public void CirclesCanHaveTheirAreaCalculated(int r)
        {
            AreaCalculator calculator = new AreaCalculator(new object[] { new Circle(r) });

            var output = calculator.Areas();

            Assert.AreEqual("Circle: " + (r * r * Math.PI).ToString(), output);
        }

        [TestCase]
        public void OneShapeIsAddedPerLine()
        {
            var circle1 = new Circle(5);
            var circle2 = new Circle(9);
            AreaCalculator calculator = new AreaCalculator(new object[] { circle1, circle2 });
            var output = calculator.Areas();

            var lines = output.Split('\n');

            Assert.AreEqual(2, lines.Length);
        }

        [TestCase]
        public void CombinationsOfCirclesAndRectanglesCanHaveTheirAreaCalculated()
        {
            var circle1 = new Circle(5);
            var circle2 = new Circle(9);
            var rectangle1 = new Rectangle(2, 3);
            var rectangle2 = new Rectangle(5, 8);
            AreaCalculator calculator = new AreaCalculator(new object[] { circle1, rectangle1, rectangle2, circle2 });

            var output = calculator.Areas();

            var lines = output.Split('\n');
            Assert.AreEqual("Circle: " + (5 * 5 * Math.PI).ToString(), lines[0]);
            Assert.AreEqual("Rectangle: " + (2 * 3).ToString(), lines[1]);
            Assert.AreEqual("Rectangle: " + (5 * 8).ToString(), lines[2]);
            Assert.AreEqual("Circle: " + (9 * 9 * Math.PI).ToString(), lines[3]);
        }
    }
}
