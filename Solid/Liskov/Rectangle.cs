namespace Solid.Liskov
{
    internal class Rectangle
    {
        private int _width;
        private int _height;

        public int GetWidth()
        {
            return _width;
        }

        public virtual void SetWidth(int value)
        {
            _width = value;
        }


        public int GetHeight()
        {
            return _height;
        }

        public virtual void SetHeight(int value)
        {
            _height = value;
        }

        public int Area => GetWidth() * GetHeight();
    }
}
