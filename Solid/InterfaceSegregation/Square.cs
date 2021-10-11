namespace Solid.InterfaceSegregation
{
    class Square : Shape
    {
        private readonly int width;
        private readonly int height;

        public Square(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return Width() * Height();
        }

        public double Depth()
        {
            return 0;
        }

        public double Height()
        {
            return height;
        }

        public double Radius()
        {
            throw new System.NotImplementedException();
        }

        public double Volume()
        {
            return Width() * Height() * Depth();
        }

        public double Width()
        {
            return width;
        }
    }
}
