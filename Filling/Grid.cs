using System.Drawing;
using System.Windows.Forms;

namespace Filling
{
    public class Grid
    {
        private int N;
        private int M;
        private int BoxWidth;
        private int BoxHeight;
        private int R = 5;
        private Triangle[] Triangles;
        private DirectBitmap directBitmap;

        public Grid(int pictureBoxWidth, int pictureBoxHeight, int N = 10, int M = 15)
        {
            this.N = N;
            this.M = M;
            BoxWidth = pictureBoxWidth / N;
            BoxHeight = pictureBoxHeight / M;
            Triangles = new Triangle[2 * N * M];
            directBitmap = new DirectBitmap(pictureBoxWidth, pictureBoxHeight);

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    Triangles[2 * i * N + 2 * j] = new Triangle(new Point(BoxWidth * j, BoxHeight * i), new Point(BoxWidth * (j + 1), BoxHeight * i), new Point(BoxWidth * j, BoxHeight * (i + 1)));
                    Triangles[2 * i * N + 2 * j + 1] = new Triangle(new Point(BoxWidth * (j + 1), BoxHeight * (i + 1)), new Point(BoxWidth * (j + 1), BoxHeight * i), new Point(BoxWidth * j, BoxHeight * (i + 1)));
                }
        }

        public void Paint(PictureBox pictureBox)
        {
            directBitmap.Dispose();
            directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            for (int i = 0; i < 2 * N * M; i++)
            {
                Triangles[i].Fill(directBitmap);
                Triangles[i].Draw(directBitmap);
            }

            pictureBox.Image.Dispose();
            pictureBox.Image = directBitmap.Bitmap;
        }

        public bool IsCloseToInnerVertex(Point p)
        {
            return (p.X % BoxWidth < R || p.X % BoxWidth > (BoxWidth - R)) && (p.Y % BoxHeight < R || p.Y % BoxHeight > (BoxHeight - R));
        }
    }
}
