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
        private class Edge
        {
            public int ymax { get; }
            public double x { get; private set; }
            public double p { get; }   // = 1/m

            public Edge(int ymax, double x, double p)
            {
                this.ymax = ymax;
                this.x = x;
                this.p = p;
            }

            public Edge(Point P1, Point P2)
            {
                if (P1.Y > P2.Y)
                {
                    ymax = P1.Y;
                    x = P2.X;
                }
                else
                {
                    ymax = P2.Y;
                    x = P1.X;
                }
                p = P2.Y - P1.Y == 0 ? 0.0f : (double)(P2.X - P1.X) / (P2.Y - P1.Y);
            }

            public void AddP()
            {
                x += p;
            }
        }

        private Point[] Points { get; }
        private int yMin { get; }
        private int yMax { get; }
        private Dictionary<int, List<Edge>> ET;

        public Triangle(Point p1, Point p2, Point p3)
        {
            Points = new Point[3];
            Points[0] = p1;
            Points[1] = p2;
            Points[2] = p3;
            yMin = Math.Min(p1.Y, Math.Min(p2.Y, p3.Y));
            yMax = Math.Max(p1.Y, Math.Max(p2.Y, p3.Y));
            ET = new Dictionary<int, List<Edge>>();

            // filling Buckets
            int y;
            Edge e;
            for (int i = 0; i < Points.Length - 1; i++)
            {
                y = Math.Min(Points[i].Y, Points[i + 1].Y);
                e = new Edge(Points[i], Points[i + 1]);
                if (!ET.ContainsKey(y))
                    ET.Add(y, new List<Edge>());
                ET[y].Add(e);
            }
            y = Math.Min(Points[Points.Length - 1].Y, Points[0].Y);
            e = new Edge(Points[Points.Length - 1], Points[0]);
            if (!ET.ContainsKey(y))
                ET.Add(y, new List<Edge>());
            ET[y].Add(e);
        }

        public void Draw(DirectBitmap bmp)
        {
            Graphics G = Graphics.FromImage(bmp.Bitmap);

            for (int i = 0; i < Points.Length - 1; i++)
                G.DrawLine(Pens.Black, Points[i], Points[i + 1]);
            G.DrawLine(Pens.Black, Points[Points.Length - 1], Points[0]);

            G.Dispose();
        }

        public void Fill(DirectBitmap bmp)
        {
            List<Edge> AET = new List<Edge>();
            for (int y = yMin; y <= yMax; y++)
            {
                if (ET.ContainsKey(y))
                {
                    AET.AddRange(ET[y].ConvertAll(e => new Edge(e.ymax, e.x, e.p)));    // AddRange of COPIES
                }
                AET.Sort((e1, e2) => e1.x.CompareTo(e2.x));

                // TODO: algorytm uproszczony, działa tylko dla trójkątów
                if (AET.Count == 2 || AET.Count == 3)
                {
                    Point P1 = new Point(Convert.ToInt32(AET[0].x + 1.0), y);
                    Point P2 = new Point(Convert.ToInt32(AET[1].x - 1.0), y);
                    for (int x = P1.X; x <= P2.X; x++)
                    {
                        //bmp.SetPixel(x, P1.Y, image.GetPixel(x % image.Width, y % image.Height));
                        bmp.SetPixel(x, P1.Y, Color.Red);
                    }
                    //if (P1.X < P2.X)
                    //    G.DrawLine(Pens.Red, P1, P2);
                    //else if (P1.X == P2.X)
                    //    bmp.SetPixel(P1.X, P1.Y, Color.Red);
                }

                for (int i = 0; i < AET.Count; i++)
                {
                    if (AET[i].ymax == y)
                    {
                        AET.RemoveAt(i);
                        i--;
                    }
                    else
                        AET[i].AddP();
                }
            }
        }
    }
}
