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
        private Bitmap map;
        private Grid Grid;
        private System.Timers.Timer timer;

        private LambertParameters lambertParameters;

        public Form1()
        {
            InitializeComponent();
            lightZMinLabel.Text = lightZTrackBar.Minimum.ToString();
            lightZMaxLabel.Text = lightZTrackBar.Maximum.ToString();

            pictureBox.Image = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            img = new Bitmap(Image.FromFile($"{openFileDialog1.InitialDirectory}\\photo2.jpg"), pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            map = Image.FromFile($"{mapOpenFileDialog.InitialDirectory}\\{mapOpenFileDialog.FileName}") as Bitmap;

            // początkowe wartości Lambert:
            lambertParameters = new LambertParameters
            {
                kd = Convert.ToDouble(kdTrackBar.Value / 100.0),
                ks = Convert.ToDouble(ksTrackBar.Value / 100.0),
                m = mTrackBar.Value,
                Light = Color.FromArgb(255, 255, 255),  //white

                LightPosition = (pictureBox.ClientSize.Width / 2, pictureBox.ClientSize.Height / 2, lightZTrackBar.Value),
                LightR = 100,
                T = 5.0,
                UseLight = true,

                CenterCoords = (pictureBox.ClientSize.Width / 2, pictureBox.ClientSize.Height / 2),
                ReflectorH = 10,
                ReflectorColor = Color.Red,

                t = 0.0,
                Normal = (x, y) => (0.0, 0.0, 1.0),
                V = (0.0, 0.0, 1.0)
            };

            Grid = new Grid(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value, img.GetPixel, Color.Black);

            timer = new System.Timers.Timer(500);
            timer.AutoReset = true;
            timer.Elapsed += AddToTimer;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image.Dispose();
            //if (lambertCheckBox.Checked)
                pictureBox.Image = Grid.Paint(contourCheckBox.Checked, lambertParameters.GetColor);
            //else
                //pictureBox.Image = Grid.Paint(contourCheckBox.Checked);
            flowLayoutPanel1.Refresh();
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
            lightZValue.Refresh();
        }

        private void kdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.kd = Convert.ToDouble(kdTrackBar.Value) / Convert.ToDouble(kdTrackBar.Maximum);
            kdLabel.Text = (kdTrackBar.Value / 100.0).ToString();
            if (lambertParameters.ks*100 + kdTrackBar.Value > 100)
            {
                lambertParameters.ks = (100.0 - kdTrackBar.Value) / 100.0;
                ksTrackBar.Value = Convert.ToInt32(lambertParameters.ks * 100);
            }
            kdLabel.Refresh();
        }

        private void ksTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.ks = Convert.ToDouble(ksTrackBar.Value) / Convert.ToDouble(ksTrackBar.Maximum);
            ksLabel.Text = (ksTrackBar.Value / 100.0).ToString();
            if (lambertParameters.kd*100 + ksTrackBar.Value > 100)
            {
                lambertParameters.kd = (100.0 - ksTrackBar.Value) / 100.0;
                kdTrackBar.Value = Convert.ToInt32(lambertParameters.kd * 100);
            }
            ksLabel.Refresh();
        }

        private void mTrackBar_ValueChanged(object sender, EventArgs e)
        {
            lambertParameters.m = mTrackBar.Value;
            mLabel.Text = mTrackBar.Value.ToString();
            mLabel.Refresh();
        }

        private void lambertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lambertParameters.UseLight = lightZTrackBar.Enabled = lambertCheckBox.Checked;
        }

        private void constVecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (constVecRadioButton.Checked)
                lambertParameters.Normal = (x, y) => (0.0, 0.0, 1.0);
        }

        private void mapVecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mapVecRadioButton.Checked)
            {
                changeMapButton.Enabled = true;
                lambertParameters.Normal = (x, y) =>
                {
                    Color c = map.GetPixel(x % map.Width, y % map.Height);
                    double X = (c.R / 255.0 * 2.0) - 1.0;
                    double Y = (c.G / 255.0 * 2.0) - 1.0;
                    double Z = (c.B / 255.0 * 2.0);
                    return (X, Y, Z);
                };
            }
            else
                changeMapButton.Enabled = false;
        }

        private void changeMapButton_Click(object sender, EventArgs e)
        {
            if (mapOpenFileDialog.ShowDialog() == DialogResult.OK)
                map = Image.FromFile($"{mapOpenFileDialog.FileName}") as Bitmap;
        }

        private void timeStartButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            lightZTrackBar.Enabled = false;
        }

        private void timerStopButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            lambertParameters.LightPosition = (lambertParameters.CenterCoords.x, lambertParameters.CenterCoords.y, lightZTrackBar.Value);
            lightZTrackBar.Enabled = true;
        }

        private void AddToTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            lambertParameters.MoveLight();
            lightZValue.Text = lambertParameters.LightPosition.z.ToString();
        }

        private void lightColorButton_Click(object sender, EventArgs e)
        {
            if (lightColorDialog.ShowDialog() == DialogResult.OK)
                lambertParameters.Light = lightColorDialog.Color;
        }

        private void reflectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reflectorCheckBox.Checked)
                lambertParameters.ReflectorH = 10;
            else
                lambertParameters.ReflectorH = -1;
        }
    }
}
