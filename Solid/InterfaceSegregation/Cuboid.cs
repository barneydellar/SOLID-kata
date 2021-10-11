namespace Solid.InterfaceSegregation
{
    class Cuboid : Shape
    {
        private int width;
        private int height;
        private int depth;

        public Cuboid(int width, int height, int depth3)
        {
            this.width = width;
            this.height = height;
            this.depth = depth3;
        }

        public double Area()
        {
            return 2 * (width*height + width*depth + depth*height) ;
        }

        public double Depth()
        {
            return depth;
        }

        public double Height()
        {
            return height;
        }

        public double Radius()
        {
            return 0;
        }

        public double Volume()
        {
            return width * depth * height;
        }

        public double Width()
        {
            return width;
        }
    }
}
