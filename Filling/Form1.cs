using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Filling
{
    public partial class Form1 : Form
    {
        private Grid Grid;
        private Point MiddleDown;
        private Func<int, int, Color> insideColor = (x, y) => Color.Red;
        private Color contourColor = Color.Black;
        private Bitmap img;
        //private BitmapData data;

        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);

            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = new Bitmap(Grid.Paint(insideColor, contourColor, contourCheckBox.Checked), pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (Grid.SetVertexToMove(e.Location))
                    MiddleDown = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (Grid.TryMoveVertex(MiddleDown, e.Location))
                    MiddleDown = e.Location;
            }

            else if (e.Button == MouseButtons.None)
            {
                if (Grid.IsCloseToInnerVertex(e.Location))
                    pictureBox.Cursor = Cursors.Hand;
                else
                    pictureBox.Cursor = Cursors.Default;
            }
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (insideColorDialog.ShowDialog(this) == DialogResult.OK)
                insideColor = (x, y) => insideColorDialog.Color;
        }

        private void pictureButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                if (!(img is null))
                    img.Dispose();

                img = new Bitmap(Image.FromFile(openFileDialog1.FileName), pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
                //directBitmap = new DirectBitmap(pictureBox.Width, pictureBox.Height, openFileDialog1.FileName);
                //data = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, img.PixelFormat);

                ////int x, y;
                ////byte bitsPerPixel = 32;
                ////int size = data.Stride * data.Height;

                ////byte* d = (byte*)(data.Scan0 + y * data.Stride + x * bitsPerPixel / 8);

                //int bytes = Math.Abs(data.Stride) * data.Height;
                //imgValues = new byte[bytes];
                //System.Runtime.InteropServices.Marshal.Copy(data.Scan0, imgValues, 0, bytes);

                insideColor = (x, y) => img.GetPixel(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contourColorDialog.ShowDialog() == DialogResult.OK)
                contourColor = contourColorDialog.Color;
        }
    }
}
