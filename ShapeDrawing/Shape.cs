using System;
using System.Drawing;

namespace ShapeDrawing
{
    public interface Shape
    {
        
        void Draw(DrawMethods DM, Pen pen);
    }
}