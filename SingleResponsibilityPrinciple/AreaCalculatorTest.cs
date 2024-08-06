namespace SingleResponsibilityPrinciple;

internal class AreaCalculatorTest
{
    [Test]
    public void AreaCalculatorsCanBeCreated()
    {
        _ = new AreaCalculator([]);
    }

    [TestCase(5, 10)]
    [TestCase(2, 3)]
    public void RectanglesCanHaveTheirAreaCalculated(int w, int h)
    {
        var calculator = new AreaCalculator([new Rectangle(w, h)]);

        var output = calculator.Areas();

        Assert.That(output, Is.EqualTo("Rectangle: " + w*h));
    }

    [TestCase(5)]
    [TestCase(7)]
    public void CirclesCanHaveTheirAreaCalculated(int r)
    {
        var calculator = new AreaCalculator([new Circle(r)]);

        var output = calculator.Areas();

        Assert.That(output, Is.EqualTo("Circle: " + r * r * Math.PI));
    }

    [Test]
    public void OneShapeIsAddedPerLine()
    {
        var circle1 = new Circle(5);
        var circle2 = new Circle(9);
        var calculator = new AreaCalculator([circle1, circle2]);
        var output = calculator.Areas();

        var lines = output.Split('\n');

        Assert.That(lines.Length, Is.EqualTo(2));
    }

    [Test]
    public void CombinationsOfCirclesAndRectanglesCanHaveTheirAreaCalculated()
    {
        var circle1 = new Circle(5);
        var circle2 = new Circle(9);
        var rectangle1 = new Rectangle(2, 3);
        var rectangle2 = new Rectangle(5, 8);
        var calculator = new AreaCalculator([circle1, rectangle1, rectangle2, circle2]);

        var output = calculator.Areas();

        var lines = output.Split('\n');
        Assert.That(lines[0], Is.EqualTo("Circle: " + 5 * 5 * Math.PI));
        Assert.That(lines[1], Is.EqualTo("Rectangle: " + 2 * 3));
        Assert.That(lines[2], Is.EqualTo("Rectangle: " + 5 * 8));
        Assert.That(lines[3], Is.EqualTo("Circle: " + 9 * 9 * Math.PI));
    }
}