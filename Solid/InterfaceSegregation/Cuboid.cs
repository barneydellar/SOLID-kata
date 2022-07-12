namespace Solid.InterfaceSegregation
{
    internal class Cuboid : IShape
    {
        private readonly int _width;
        private readonly int _height;
        private readonly int _depth;

        public Cuboid(int width, int height, int depth)
        {
            _width = width;
            _height = height;
            _depth = depth;
        }

        public double Area()
        {
            return 2 * (_width*_height + _width*_depth + _depth*_height) ;
        }

        public double Depth()
        {
            return _depth;
        }

        public double Height()
        {
            return _height;
        }

        public double Radius()
        {
            return 0;
        }

        public double Volume()
        {
            return _width * _depth * _height;
        }

        public double Width()
        {
            return _width;
        }
    }
}
