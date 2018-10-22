using System.Drawing;

namespace ShapeDrawing
{
    public interface DrawMethods
    {
        //enige overeenkomstige methodes moeten hier
        void DrawLines(Pen pen, int x1, int y1, int x2, int y2);

        void DrawCircle(Pen pen, int x, int y, int r);

        void DrawRectangle(Pen pen, int x, int y, int h, int w);
        
    }
}
