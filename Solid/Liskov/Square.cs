namespace Solid.Liskov;

// Squares are a special case of rectangles.
internal class Square : Rectangle
{
    public override void SetWidth(int value)
    {
        base.SetWidth(value);
        base.SetHeight(value);
    }

    public override void SetHeight(int value)
    {
        base.SetWidth(value);
        base.SetHeight(value);
    }
}