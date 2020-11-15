using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Filling
{
    public partial class Form1 : Form
    {
        private Point MouseMiddleDown;
        private Bitmap img;
        private Grid Grid;

        private LambertParameters lambertParameters;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="kd"></param>
        /// <param name="light"></param>
        /// <param name="pixel"></param>
        /// <param name="lightposition"></param>
        /// <param name="N">wektor normalny</param>
        /// <returns></returns>
        //public static Color Lambert(int x, int y, double kd, Color light, Color pixel, (int x, int y, int z) lightposition, (double x, double y, double z) N)
        //{
        //    (double R, double G, double B) Il = (light.R / 255.0, light.G / 255.0, light.B / 255.0);
        //    (double R, double G, double B) Io = (pixel.R / 255.0, pixel.G / 255.0, pixel.B / 255.0);

        //    (int x, int y, int z) lightVector = (lightposition.x - x, lightposition.y - y, lightposition.z);
        //    double lightVecLen = Math.Sqrt(lightVector.x*lightVector.x + lightVector.y*lightVector.y + lightVector.z*lightVector.z);
        //    (double x, double y, double z) L = (lightVector.x / lightVecLen, lightVector.y / lightVecLen, lightVector.z / lightVecLen); //wersor do światła

        //    double cosNL = L.x*N.x + L.y*N.y + L.z*N.z;
        //    if (double.IsNaN(cosNL))
        //        cosNL = 0.0;

        //    double R = kd * Il.R * Io.R * cosNL;
        //    double G = kd * Il.G * Io.G * cosNL;
        //    double B = kd * Il.B * Io.B * cosNL;

        //    return Color.FromArgb(Convert.ToInt32(R*255), Convert.ToInt32(G*255), Convert.ToInt32(B*255));
        //}
        //private Func<int, int, Color> UseLambert = (x, y) => Lambert(x, y, 1.0, Color.White, Color.Red, lightPosition, normalVersor);
        //private Func<int, int, Color> Lmb(double kd, Color light, Color pixel, (int x, int y, int z) lightposition, (double x, double y, double z) N)
        //{
        //    return (x, y) => Lambert(x, y, kd, light, pixel, lightposition, N);
        //}

        public Form1()
        {
            InitializeComponent();
            lightZMinLabel.Text = lightZTrackBar.Minimum.ToString();
            lightZMaxLabel.Text = lightZTrackBar.Maximum.ToString();

            pictureBox.Image = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            img = new Bitmap(Image.FromFile($"{openFileDialog1.InitialDirectory}/photo2.jpg"), pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);

            // początkowe wartości Lambert:
            lambertParameters = new LambertParameters
            {
                kd = 1.0,
                ks = 0.0,
                m = 1,
                Light = Color.FromArgb(255, 255, 255),  //white
                LightPosition = (pictureBox.ClientSize.Width / 2, pictureBox.ClientSize.Height / 2, lightZTrackBar.Value),
                N = (0.0, 0.0, 1.0),
                V = (0.0, 0.0, 1.0)
            };

            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value, img.GetPixel, Color.Black);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image.Dispose();
            if (lambertCheckBox.Checked)
                pictureBox.Image = Grid.Paint(contourCheckBox.Checked, lambertParameters.GetColor);
            else
                pictureBox.Image = Grid.Paint(contourCheckBox.Checked);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Grid.SetVertexToMove(e.Location))
                    MouseMiddleDown = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Grid.TryMoveVertex(MouseMiddleDown, e.Location))
                    MouseMiddleDown = e.Location;
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
            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value, Grid.InsideColor, Grid.ContourColor);
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value, Grid.InsideColor, Grid.ContourColor);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (insideColorDialog.ShowDialog(this) == DialogResult.OK)
                Grid.InsideColor = (x, y) => insideColorDialog.Color;
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

                Grid.InsideColor = (x, y) => img.GetPixel(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contourColorDialog.ShowDialog() == DialogResult.OK)
                Grid.ContourColor = contourColorDialog.Color;
        }

        private void lightZTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.LightPosition.z = lightZTrackBar.Value;
            lightZValue.Text = lightZTrackBar.Value.ToString();
        }

        private void kdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            //ksTrackBar.Value = 100 - kdTrackBar.Value;
            lambertParameters.kd = Convert.ToDouble(kdTrackBar.Value) / Convert.ToDouble(kdTrackBar.Maximum);
        }

        private void ksTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.ks = Convert.ToDouble(ksTrackBar.Value) / Convert.ToDouble(ksTrackBar.Maximum);
        }

        private void mTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.m = mTrackBar.Value;
        }
    }
}
