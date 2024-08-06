namespace SingleResponsibilityPrinciple;

internal class AreaCalculator(object[] shapes)
{
    public string Areas()
    {
        var lines = new List<string>();
        foreach (var shape in shapes) {
            if (shape is Rectangle rectangle)
            {
                lines.Add("Rectangle: " + rectangle.Width * rectangle.Height);
            } 
            else if (shape is Circle circle)
            {
                lines.Add("Circle: " + Math.Pow(circle.Radius, 2) * Math.PI);
            }
        }
        return string.Join('\n', lines);
    }
}