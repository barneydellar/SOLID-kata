using System;
using System.Collections.Generic;

namespace Solid.SingleResponsibility;

internal class AreaCalculator
{
    private readonly object[] _shapes;

    public AreaCalculator(object[] shapes)
    {
        _shapes = shapes;
    }

    public string Areas()
    {
        var lines = new List<string>();
        foreach (var shape in _shapes) {
            if (shape is Rectangle)
            {
                lines.Add("Rectangle: " + (shape as Rectangle).Width * (shape as Rectangle).Height);
            } else
            {
                lines.Add("Circle: " + Math.Pow((shape as Circle).Radius, 2) * Math.PI);
            }
        }
        return string.Join('\n', lines);
    }
}