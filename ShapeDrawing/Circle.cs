using System;
using System.Drawing;

namespace ShapeDrawing
{
    class Circle : Shape
    {
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
            Canvas.DrawEllipse(pen, x, y, size, size);
        }
    }
}