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

        public void Draw(DrawMethods DM, Pen pen)
        {
            DM.DrawCircle(pen, x, y, size);
        }
    }
}