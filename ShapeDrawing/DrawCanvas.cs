using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class DrawCanvas : DrawMethods
    {
        Graphics Canvas;
        public DrawCanvas(Graphics G) : base()
        {
            Canvas = G;
        }
        public override void DrawLines()
        {
            base.DrawLines();
        }
        public override void DrawRectangle()
        {
            base.DrawRectangle();
        }
        public override void DrawCircle()
        {
            base.DrawCircle();
        }
    }
}
