using System.Drawing;

namespace ShapeDrawing
{
    class Rectangle : Shape
    {
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
        }
    }
}
