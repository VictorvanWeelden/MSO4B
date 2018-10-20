using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    abstract class DrawMethods
    {
        public DrawMethods()
        {
        }
        //enige overeenkomstige methodes moeten hier
        public abstract void DrawLines(Pen pen, int x1, int y1, int x2, int y2);

        public abstract void DrawCircle(Pen pen, int x, int y, int r);
        
    }
}
