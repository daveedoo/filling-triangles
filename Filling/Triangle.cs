using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filling
{
    public class Triangle
    {
        private Point P1, P2, P3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
        }

        public void Draw(Bitmap bmp)
        {
            Graphics G = Graphics.FromImage(bmp);
            G.DrawLine(Pens.Black, P1, P2);
            G.DrawLine(Pens.Black, P2, P3);
            G.DrawLine(Pens.Black, P3, P1);
            G.Dispose();
        }
    }
}
