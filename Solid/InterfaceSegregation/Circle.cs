using System;

namespace Solid.InterfaceSegregation
{
    class Circle : Shape
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public double Depth()
        {
            return 0;
        }

        public double Height()
        {
            return 0;
        }

        public double Radius()
        {
            return radius;
        }

        public double Volume()
        {
            throw new System.NotImplementedException();
        }

        public double Width()
        {
            return 0;
        }
    }
}
