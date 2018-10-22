using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShapeDrawing
{
    public class DrawSVG : DrawMethods
    {
        public static List<string> text = new List<string>();
        string regels;
        public DrawSVG()
        {}
        //implementeer SVG schrijven
        public void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {           
            regels = "<line x1 = \"" + x1 + "\" y1 = \"" + y1 + "\" x2 = \"" + x2 + "\" y2 = \"" + y2 + "\" style = \"stroke:rgb(0,0,0);stroke-width:1\" />";
            text.Add(regels);         
        }
        public void DrawRectangle(Pen pen, int x, int y, int w, int h)
        {
            regels = "<rect x = \"" + x + "\" y = \"" + y + "\" width = \"" + w + "\" height = \"" + h + " \"style = \"fill:rgb(0,0,0);stroke-width:1;stroke:rgb(0,0,0)\" />";
            text.Add(regels);
        }
        public void DrawCircle(Pen pen, int x, int y, int r)
        {
            regels = "<circle cx =\"" + x + "\" cx =\"" + y + "\" r = \"" + r + "\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />";
            text.Add(regels);
        }
    }
}
