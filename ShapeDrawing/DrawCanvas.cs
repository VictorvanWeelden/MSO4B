using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class DrawCanvas : DrawMethods
    {
        Pen pen;
        Graphics Canvas;
        public DrawCanvas(Graphics G, Pen pen) : base()
        {
            Canvas = G;
            this.pen = pen;
        }
        public override void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {
            Canvas.DrawLine(pen, x1, y1, x2, y2);
        }
        public override void DrawCircle(Pen pen, int x, int y, int r)
        {
            Canvas.DrawEllipse(pen, x, y, r, r);
        }

        public void DrawRecangle(Pen pen, int x, int y, int h, int w)
        {
            DrawLines(pen, x, y, x + w, y);
            DrawLines(pen, x + w, y, x + w, y + h);
            DrawLines(pen, x + w, y + h, x, y + h);
            DrawLines(pen, x, y + h, x, y);
        }
    }
}
