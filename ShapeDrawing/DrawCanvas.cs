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
        public DrawCanvas(Graphics G, Pen pen)
        {
            Canvas = G;
            this.pen = pen;
        }
        public void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {
            Canvas.DrawLine(pen, x1, y1, x2, y2);
        }
        public void DrawCircle(Pen pen, int x, int y, int r)
        {
            Canvas.DrawEllipse(pen, x, y, r, r);
        }

        public void DrawRectangle(Pen pen, int x, int y, int h, int w)
        {
            DrawLines(pen, x, y, x + w, y);
            DrawLines(pen, x + w, y, x + w, y + h);
            DrawLines(pen, x + w, y + h, x, y + h);
            DrawLines(pen, x, y + h, x, y);
        }
    }
}
