using System;
using System.Drawing;

namespace ShapeDrawing
{
    public interface Shape
    {
        void Draw(Graphics Canvas, Pen pen);
    }
}