using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Filling
{
    public class Grid
    {
        private int yUnits;     // liczba komórek po współrzędnej Y
        private int xUnits;     // liczba komórek po współrzędnej X
        //private int Width;    // używana szerokość bitmapy
        //private int Height;   // używana wysokość bitmapy

        private int mvIndex = -1;  // index przesuwanego wierzchołka
        private int R = 5;      // "promień" wierzchołków - do ich przesuwania
        private Triangle[] Triangles;
        private DirectBitmap directBitmap;

        public Color ContourColor { get; set; }
        public Func<int, int, Color> InsideColor { get; set; }

        public Grid(int pictureBoxWidth, int pictureBoxHeight, int xUnits, int yUnits, Func<int, int, Color> insideColor, Color contour)
        {
            if (xUnits < 1 || yUnits < 1)
                throw new ArgumentException("Grid dimensions should be positive.");
            if (pictureBoxWidth < 0 || pictureBoxHeight < 0)
                throw new ArgumentException("Incorrect pictureBox dimensions.");
            ContourColor = contour;
            InsideColor = insideColor;

            int unitWidth = pictureBoxWidth / xUnits;
            int unitHeight = pictureBoxHeight / yUnits;
            this.xUnits = xUnits;
            this.yUnits = yUnits;
            //Width = unitWidth * xUnits + 1;
            //Height = unitHeight * yUnits + 1;

            Triangles = new Triangle[2 * xUnits * yUnits];
            directBitmap = new DirectBitmap(pictureBoxWidth, pictureBoxHeight);

            for (int i = 0; i < yUnits; i++)
                for (int j = 0; j < xUnits; j++)
                {// kolejność punktów istotna
                    Triangles[2 * i * xUnits + 2 * j] = new Triangle(new Point(unitWidth * j, unitHeight * i),
                        new Point(unitWidth * (j + 1), unitHeight * i),
                        new Point(unitWidth * j, unitHeight * (i + 1)));
                    Triangles[2 * i * xUnits + 2 * j + 1] = new Triangle(new Point(unitWidth * (j + 1), unitHeight * (i + 1)),
                        new Point(unitWidth * (j + 1), unitHeight * i),
                        new Point(unitWidth * j, unitHeight * (i + 1)));
                }
        }

        public Bitmap Paint(bool drawContours = true, Func<int, int, Color, Color> modification = null)
        {
            directBitmap.Dispose();
            directBitmap = new DirectBitmap(directBitmap.Width, directBitmap.Height);

            if (!(modification is null))
                for (int i = 0; i < 2 * yUnits * xUnits; i++)
                    Triangles[i].Fill(directBitmap, (x, y) => modification(x, y, InsideColor(x, y)));
            else
                for (int i = 0; i < 2 * yUnits * xUnits; i++)
                    Triangles[i].Fill(directBitmap, InsideColor);

            if (drawContours)
                for (int i = 0; i < 2 * yUnits * xUnits; i++)
                    Triangles[i].Draw(directBitmap, ContourColor);

            return directBitmap.Bitmap.Clone() as Bitmap;
        }

        public bool SetVertexToMove(Point m)
        {
            mvIndex = CloseTriangle(m);
            if (mvIndex == -1)
                return false;
            return true;
        }

        public bool TryMoveVertex(Point from, Point to)
        {
            if (mvIndex == -1)
                return false;

            int offX = to.X - from.X;
            int offY = to.Y - from.Y;
            Triangles[mvIndex - 2 * xUnits - 1].Offset(0, to.X - from.X, to.Y - from.Y);
            Triangles[mvIndex - 2 * xUnits].Offset(2, to.X - from.X, to.Y - from.Y);
            Triangles[mvIndex - 2 * xUnits + 1].Offset(2, to.X - from.X, to.Y - from.Y);
            Triangles[mvIndex - 2].Offset(1, offX, offY);
            Triangles[mvIndex - 1].Offset(1, offX, offY);
            Triangles[mvIndex].Offset(0, offX, offY);

            return true;
        }

        public bool IsCloseToInnerVertex(Point m)
        {
            return CloseTriangle(m) != -1;
        }
        // Dla takiego początkowego(!) ułożenia trójkątów:
        // _|__|__|_
        //  | /| /|
        // _|/_|/_|_
        //  | /|X/|
        // _|/_|/_|_
        //  |  |  |
        // jeśli punkt p jest blisko tego środkowego, wspólnego wierzchołka - metoda zwraca indeks trójkąta X w tablicy Triangles.
        // wpp. -1.
        // Jeśli punkt jest blisko krawędzi: -1
        private int CloseTriangle(Point m)
        {
            if (m.X < R || m.X > (directBitmap.Width - R) || m.Y < R || m.Y > (directBitmap.Height - R) ||    // punkt przy krawędzi
                xUnits < 2 || yUnits < 2)   //nie ma w gridzie punktów wewnętrznych
                return -1;

            Point pt;
            for (int i = 1; i < yUnits; i++)
                for (int j = 1; j < xUnits; j++)
                {
                    int index = 2*i*xUnits + 2*j;
                    pt = Triangles[index][0];
                    if (Math.Abs(pt.X - m.X) < R && Math.Abs(pt.Y - m.Y) < R)
                        return index;
                }
            return -1;
        }
    }
}
