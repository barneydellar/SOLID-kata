using NUnit.Framework;
using System;

namespace Solid.SingleResponsibility;

internal class AreaCalculatorTest
{
    [Test]
    public void AreaCalculatorsCanBeCreated()
    {
        var calculator = new AreaCalculator(new object[] { });
    }

    [TestCase(5, 10)]
    [TestCase(2, 3)]
    public void RectanglesCanHaveTheirAreaCalculated(int w, int h)
    {
        var calculator = new AreaCalculator(new object[] { new Rectangle(w, h) });

        var output = calculator.Areas();

        Assert.AreEqual("Rectangle: " + (w*h), output);
    }

    [TestCase(5)]
    [TestCase(7)]
    public void CirclesCanHaveTheirAreaCalculated(int r)
    {
        var calculator = new AreaCalculator(new object[] { new Circle(r) });

        var output = calculator.Areas();

        Assert.AreEqual("Circle: " + (r * r * Math.PI), output);
    }

    [Test]
    public void OneShapeIsAddedPerLine()
    {
        var circle1 = new Circle(5);
        var circle2 = new Circle(9);
        var calculator = new AreaCalculator(new object[] { circle1, circle2 });
        var output = calculator.Areas();

        var lines = output.Split('\n');

        Assert.AreEqual(2, lines.Length);
    }

    [Test]
    public void CombinationsOfCirclesAndRectanglesCanHaveTheirAreaCalculated()
    {
        var circle1 = new Circle(5);
        var circle2 = new Circle(9);
        var rectangle1 = new Rectangle(2, 3);
        var rectangle2 = new Rectangle(5, 8);
        var calculator = new AreaCalculator(new object[] { circle1, rectangle1, rectangle2, circle2 });

        var output = calculator.Areas();

        var lines = output.Split('\n');
        Assert.AreEqual("Circle: " + (5 * 5 * Math.PI), lines[0]);
        Assert.AreEqual("Rectangle: " + (2 * 3), lines[1]);
        Assert.AreEqual("Rectangle: " + (5 * 8), lines[2]);
        Assert.AreEqual("Circle: " + (9 * 9 * Math.PI), lines[3]);
    }
}