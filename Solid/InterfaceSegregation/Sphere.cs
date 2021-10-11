using System;

namespace Solid.InterfaceSegregation
{
    class Sphere : Shape
    {
        private readonly int radius;

        public Sphere(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return 4 * Math.Pow(radius, 2) * Math.PI;
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
            return 4.0/3.0 * Math.Pow(radius, 3) * Math.PI; ;
        }

        public double Width()
        {
            return 0;
        }
    }
}
