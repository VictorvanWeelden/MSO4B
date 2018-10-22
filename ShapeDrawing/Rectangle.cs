using System;
using System.Drawing;

namespace ShapeDrawing
{
    class Rectangle : Shape
    {
       // public DrawMethods DM;
       // public DrawSVG dm = new DrawSVG();
        private int x;
        private int y;
        private int width;
        private int height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void Draw(DrawMethods DM, Pen pen)
        {
            DM.DrawRectangle(pen, x, y, height, width);
            /*Canvas.DrawLine(pen, x, y, x + width, y);
            Canvas.DrawLine(pen, x + width, y, x + width, y + height);
            Canvas.DrawLine(pen, x + width, y + height, x, y + height);
            Canvas.DrawLine(pen, x, y + height, x, y);*/
            //dm.DrawRectangle(pen, x, y, width, height);
        }
    }
}
