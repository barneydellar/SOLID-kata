using System;

namespace Solid.InterfaceSegregation
{
    internal class Circle : IShape
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.Pow(_radius, 2) * Math.PI;
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
            return _radius;
        }

        public double Volume()
        {
            throw new NotImplementedException();
        }

        public double Width()
        {
            return 0;
        }
    }
}
