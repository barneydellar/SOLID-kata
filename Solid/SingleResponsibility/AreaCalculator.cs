using System;
using System.Collections.Generic;

namespace Solid.SingleResponsibility
{
    class AreaCalculator
    {
        private readonly object[] shapes;

        public AreaCalculator(object[] shapes)
        {
            this.shapes = shapes;
        }

        public String Areas()
        {
            List<String> lines = new List<string>();
            foreach (var shape in shapes) {
                if (shape is Rectangle)
                {
                    lines.Add("Rectangle: " + (shape as Rectangle).Width * (shape as Rectangle).Height);
                } else
                {
                    lines.Add("Circle: " + Math.Pow((shape as Circle).Radius, 2) * Math.PI);
                }
            }
            return String.Join('\n', lines);
        }
    }
}
