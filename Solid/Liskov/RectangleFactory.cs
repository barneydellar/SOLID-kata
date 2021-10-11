namespace Solid.Liskov
{
    class RectangleFactory
    {
        public static Rectangle Create()
        {
            return new Rectangle();
        }

        public static Rectangle Create2()
        {
            return new Square();
        }
    }
}
