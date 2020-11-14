using System;
using System.Collections.Generic;
using System.Drawing;

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

        private Point[] Points { get; } = new Point[3];
        private int yMin { get; set; }
        private int yMax { get; set; }
        private Dictionary<int, List<Edge>> ET;
        
        public Point this[int idx] { get => Points[idx]; }

        /// <summary>
        /// Kolejność punktów jest zachowana przez całe życie obiektu
        /// </summary>
        public Triangle(Point p0, Point p1, Point p2)
        {
            Points[0] = p0;
            Points[1] = p1;
            Points[2] = p2;
            yMin = Math.Min(p0.Y, Math.Min(p1.Y, p2.Y));
            yMax = Math.Max(p0.Y, Math.Max(p1.Y, p2.Y));
            ET = new Dictionary<int, List<Edge>>();

            // filling Buckets
            for (int i = 0; i < Points.Length - 1; i++)
                AddEdge(Points[i], Points[i + 1]);
            AddEdge(Points[Points.Length - 1], Points[0]);
        }
        private void AddEdge(Point p1, Point p2)
        {
            int y = Math.Min(p1.Y, p2.Y);
            Edge e = new Edge(p1, p2);
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

                // TODO: algorytm uproszczony, działa tylko dla trójkątów (i wielokątów wypukłych?)
                for (int i = 1; i < AET.Count; i++)
                {
                    Point P0 = new Point(Convert.ToInt32(AET[i - 1].x), y);
                    Point P1 = new Point(Convert.ToInt32(AET[i].x), y);

                    if (P1.Y > 0 && P1.Y < bmp.Height)
                        for (int x = P0.X; x < Math.Min(P1.X, bmp.Width); x++)
                            bmp.SetPixel(x, P1.Y, Color.Red);
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

        // przesuwa wierzchołek o podanym indeksie
        public void Offset(int index, int offsetX, int offsetY)
        {
            if (index < 0 || index > 2)
                throw new ArgumentException("Index is bad.");

            Points[index].Offset(offsetX, offsetY);
            ET.Clear();

            for (int i = 0; i < Points.Length - 1; i++)
                AddEdge(Points[i], Points[i + 1]);
            AddEdge(Points[Points.Length - 1], Points[0]);

            if (Points[index].Y < yMin)
                yMin = Points[index].Y;
            else if (Points[index].Y > yMax)
                yMax = Points[index].Y;
        }
    }
}
