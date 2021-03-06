using System;
using System.Drawing;

namespace ShapeDrawing
{
    public class Star : Shape
    {
        public DrawMethods DM;
        private int x;
        private int y;
        private int width;
        private int height;
        int numPoints = 5;
        Point[] pts;// uit de methode gehaald

        public Star(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            pts = new Point[numPoints];
        }

        public void Draw(DrawMethods DM, Pen pen)// parameter pen toegevoegd
        {
            CalculatePoints();
            for (int i = 0; i < numPoints; i++)
            {
                DM.DrawLines(pen, pts[i].X, pts[i].Y,
                       pts[(i + 1) % numPoints].X, pts[(i + 1) % numPoints].Y);
            }

        }

        void CalculatePoints()// Calculate methode toegevoegd
        {
            double rx = width / 2;
            double ry = height / 2;
            double cx = x + rx;
            double cy = y + ry;

            double theta = -Math.PI / 2;
            double dtheta = 4 * Math.PI / numPoints;
            for (int i = 0; i < numPoints; i++)
            {
                pts[i] = new Point(
                    Convert.ToInt32(cx + rx * Math.Cos(theta)),
                    Convert.ToInt32(cy + ry * Math.Sin(theta)));
                theta += dtheta;
            }
        }
    }
}

