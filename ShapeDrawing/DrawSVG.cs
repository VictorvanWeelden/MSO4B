using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class DrawSVG : DrawMethods
    {

        public DrawSVG()
        { }
        //implementeer SVG schrijven
        public void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("< line x1 = \""+x1 +"\" y1 = \"" +y1+ "\" x2 = \"" +x2 + "\" y2 = \""+ y2+ " style = \"stroke:rgb(0,0,0);stroke-width:2\" />");
        }
        public void DrawRectangle(Pen pen, int x, int y, int w, int h)
        {
            Console.WriteLine("< rect x = \"" +x+ "\" y = \"" +y + "\" width = \"" +w + "\" height = \""+h+" \"style = \"fill:rgb(0,0,0);stroke-width:3;stroke:rgb(0,0,0)\" />");
        }
        public void DrawCircle(Pen pen, int x, int y, int r)
        {
            Console.WriteLine("<circle cx =\"" + x +"\" cx =\"" + y +"\" r = \"" + r + "\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />" );
        }
    }
}
