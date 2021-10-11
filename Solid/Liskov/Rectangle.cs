﻿namespace Solid.Liskov
{
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area => Width * Height;
    }
}
