using System;
using System.Drawing;
using System.Windows.Forms;

namespace Filling
{
    public partial class Form1 : Form
    {
        private Grid Grid;
        private Point MiddleDown;

        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            Grid = new Grid(pictureBox.Width, pictureBox.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = Grid.Paint();
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
            Grid = new Grid(pictureBox.Width, pictureBox.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Grid = new Grid(pictureBox.Width, pictureBox.Height, (int)numericUpDownX.Value, (int)numericUpDownY.Value);
        }
    }
}
