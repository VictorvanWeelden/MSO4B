using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class DrawSVG : DrawMethods
    {
        
        public DrawSVG() : base()
        {
        }
        //implementeer SVG schrijven
        public override void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {
            //base.DrawLines(pen, x1, y1, x2, y2);
        }
        public void DrawRectangle(Pen pen, int x, int y, int w, int h)
        {
        }
        public override void DrawCircle(Pen pen, int x, int y, int r)
        {

        }
    }
}
