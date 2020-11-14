using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Filling
{
    public class Grid
    {
        private int yUnits;     // liczba komórek po współrzędnej X
        private int xUnits;     // liczba komórek po współrzędnej Y
        private int Width;
        private int Height;

        private int R = 5;      // "promień" wierzchołków
        private Triangle[] Triangles;
        private DirectBitmap directBitmap;

        private int mvIndex = -1;  // index przesuwanego wierzchołka

        public Grid(int pictureBoxWidth, int pictureBoxHeight, int N = 10, int M = 15)
        {
            if (N < 1 || M < 1)
                throw new ArgumentException("Grid dimensions should be positive.");
            if (pictureBoxWidth < 0 || pictureBoxHeight < 0)
                throw new ArgumentException("Incorrect pictureBox dimensions.");

            int unitWidth = pictureBoxWidth / N;
            int unitHeight = pictureBoxHeight / M;
            xUnits = N;
            yUnits = M;
            Width = unitWidth * xUnits + 1;
            Height = unitHeight * yUnits + 1;

            Triangles = new Triangle[2 * N * M];
            directBitmap = new DirectBitmap(pictureBoxWidth, pictureBoxHeight);

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {// kolejność punktów istotna
                    Triangles[2 * i * N + 2 * j] = new Triangle(new Point(unitWidth * j, unitHeight * i),
                        new Point(unitWidth * (j + 1), unitHeight * i),
                        new Point(unitWidth * j, unitHeight * (i + 1)));
                    Triangles[2 * i * N + 2 * j + 1] = new Triangle(new Point(unitWidth * (j + 1), unitHeight * (i + 1)),
                        new Point(unitWidth * (j + 1), unitHeight * i),
                        new Point(unitWidth * j, unitHeight * (i + 1)));
                }
        }

        public Bitmap Paint()
        {
            directBitmap.Dispose();
            directBitmap = new DirectBitmap(Width, Height);

            for (int i = 0; i < 2 * yUnits * xUnits; i++)
                Triangles[i].Fill(directBitmap);
            for (int i = 0; i < 2 * yUnits * xUnits; i++)
                Triangles[i].Draw(directBitmap);

            return directBitmap.Bitmap;
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
            if (m.X < R || m.X > (Width - R) || m.Y < R || m.Y > (Height - R) ||    // punkt przy krawędzi
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
