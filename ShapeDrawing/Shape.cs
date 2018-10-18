using System;
using System.Drawing;

namespace ShapeDrawing
{
    public abstract class Shape
    {
        
    DrawMethods Methods;
    public Shape()
        {
        }

        public abstract void Draw(Graphics Canvas);

    }
}