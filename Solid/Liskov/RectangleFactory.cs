namespace Solid.Liskov
{
    internal class RectangleFactory
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
