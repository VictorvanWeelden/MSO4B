using System;
using System.Drawing;

namespace ShapeDrawing
{
    public abstract class Shape
    {
        DrawMethods DM;
        Graphics G;

        public Shape()
        {
        }

        public abstract void Draw(Graphics Canvas);

        public virtual void Canvas_SVG(int x)
        {
            if (x == 1)
                DM = new DrawSVG();
            else
                DM = new DrawCanvas(G);
        }
    }
}