using System;
using System.Drawing;

namespace ShapeDrawing
{
    public abstract class Shape
    {
        DrawMethods DM;

        public Shape()
        {
        }

        public abstract void Draw(Graphics Canvas, Pen pen);

        public virtual void Canvas_SVG(Graphics Canvas, int x)
        {
            if (x == 1)
                DM = new DrawSVG();
            else
                DM = new DrawCanvas(Canvas);
        }
    }
}