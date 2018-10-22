using System.Drawing;
using System.Windows.Forms;

namespace ShapeDrawing
{
    public class DrawSVG : DrawMethods
    {
        public DrawSVG()
        { }
        //implementeer SVG schrijven
        public void DrawLines(Pen pen, int x1, int y1, int x2, int y2)
        {
            MessageBox.Show("< line x1 = \"" +x1 +"\" y1 = \"" +y1+ "\" x2 = \"" +x2 + "\" y2 = \""+ y2+ " style = \"stroke:rgb(0,0,0);stroke-width:2\" />");
        }
        public void DrawRectangle(Pen pen, int x, int y, int w, int h)
        {
            MessageBox.Show("< rect x = \"" +x+ "\" y = \"" +y + "\" width = \"" +w + "\" height = \""+h+" \"style = \"fill:rgb(0,0,0);stroke-width:3;stroke:rgb(0,0,0)\" />");
        }
        public void DrawCircle(Pen pen, int x, int y, int r)
        {
            MessageBox.Show("<circle cx =\"" + x +"\" cx =\"" + y +"\" r = \"" + r + "\" stroke-width=\"1\" fill=\"none\" stroke=\"black\" />" );
        }
    }
}
