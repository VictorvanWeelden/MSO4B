using System;
using System.Drawing;

namespace ShapeDrawing
{
    class Circle : Shape
    {
        public DrawMethods DM;
        public DrawSVG dm = new DrawSVG();
        private int x;
        private int y;
        private int size;

        public Circle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void Draw(Graphics Canvas, Pen pen)
        {
            //DM.DrawCircle(pen, x, y, size);
            Canvas.DrawEllipse(pen, x, y, size, size);
            dm.DrawCircle(pen, x, y, size);
        }
    }
}