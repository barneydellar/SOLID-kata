namespace Solid.Liskov
{
    class Rectangle
    {
        private int width;
        private int height;

        public virtual int GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(int value)
        {
            width = value;
        }


        public virtual int GetHeight()
        {
            return height;
        }

        public virtual void SetHeight(int value)
        {
            height = value;
        }

        public int Area => GetWidth() * GetHeight();
    }
}
