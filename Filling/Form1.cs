using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filling
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private int N = 10;
        private int M = 10;

        private Triangle[] Triangles;

        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            int w = pictureBox.Width / N;
            int h = pictureBox.Height / M;
            Triangles = new Triangle[2 * N * M];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    Triangles[2 * i * N + 2 * j] = new Triangle(new Point(w * j, h * i), new Point(w * (j + 1), h * i), new Point(w * j, h * (i + 1)));
                    Triangles[2 * i * N + 2 * j + 1] = new Triangle(new Point(w * (j + 1), h * (i + 1)), new Point(w * (j + 1), h * i), new Point(w * j, h * (i + 1)));
                }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap newBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            for (int i = 0; i < 2*N*M; i++)
            {
                Triangles[i].Draw(newBitmap);
            }
            pictureBox.Image.Dispose();
            pictureBox.Image = newBitmap;
        }
    }
}
