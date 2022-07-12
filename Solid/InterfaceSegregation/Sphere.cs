using System;

namespace Solid.InterfaceSegregation
{
    internal class Sphere : IShape
    {
        private readonly int _radius;

        public Sphere(int radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return 4 * Math.Pow(_radius, 2) * Math.PI;
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
            return 4.0/3.0 * Math.Pow(_radius, 3) * Math.PI; ;
        }

        public double Width()
        {
            return 0;
        }
    }
}
