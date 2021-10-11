namespace Solid.Liskov
{
    // Squares are a special case of rectangles.
    class Square : Rectangle
    {
        public override int Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            set
            {
                Width = value;
            }
        }
    }
}
