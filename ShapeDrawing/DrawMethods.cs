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
        public virtual void DrawLines()
        {

        }

        public abstract void DrawCircle();
        
    }
}
