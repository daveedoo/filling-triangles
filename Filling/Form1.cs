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
    public partial class Form1 : Form
    {
        private int N = 10;
        private int M = 15;
        private Grid Grid;

        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

            Grid = new Grid(pictureBox.Width, pictureBox.Height, N, M);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Grid.Paint(pictureBox);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (Grid.IsCloseToInnerVertex(e.Location))
                {
                    MessageBox.Show(this, $"da");
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (Grid.IsCloseToInnerVertex(e.Location))
                pictureBox.Cursor = Cursors.Hand;
            else
                pictureBox.Cursor = Cursors.Default;
        }
    }
}
