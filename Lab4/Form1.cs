using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            stopGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextGeneration();
        }

        private void stopGame()
        {
            if (!timer1.Enabled) return;
            timer1.Stop();
            edResolution.Enabled = true;
            edDensity.Enabled = true;
        }

        Graphics pucture;
        int resolution;       
        int coll;
        int rows;
        bool[,] field;

        private void startGame()
        {
            if (timer1.Enabled) return;

            edResolution.Enabled = false;
            edDensity.Enabled = false;

            resolution = (int)edResolution.Value;

            rows = pictureBox1.Height / resolution;
            coll = pictureBox1.Width / resolution;

            field = new bool[coll, rows];

            Random random = new Random();
            for (int x = 0; x < coll; x++)
                for (int y = 0; y < rows; y++) field[x, y] = random.Next((int)edDensity.Value) == 0;

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pucture = Graphics.FromImage(pictureBox1.Image);

            timer1.Start();
        }

        private void nextGeneration()
        {
            pucture.Clear(Color.PapayaWhip);

            var newField = new bool[coll, rows];

            for (int x = 0; x < coll; x++)
                for (int y = 0; y < rows; y++)
                {
                    var neigboursCount = neibCount(x, y);
                    bool hasLife = field[x, y];

                    if (!hasLife && neigboursCount == 3) newField[x, y] = true;
                    else if (hasLife && (neigboursCount < 2 || neigboursCount > 3)) newField[x, y] = false;
                    else newField[x, y] = field[x, y];

                    if (hasLife)
                        pucture.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
            field = newField;
            pictureBox1.Refresh();
        }

        private int neibCount(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + coll) % coll;
                    var row = (y + j + rows) % rows;
                    var isSelfChecking = col == x && row == y;
                    var hasLife = field[col, row];
                    if (hasLife && !isSelfChecking) count++;
                }

            return count;
        }
      
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled) return;

            if (e.Button == MouseButtons.Left)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;

                if (validateMousePosition(x, y)) field[x, y] = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                var x = e.Location.X / resolution;
                var y = e.Location.Y / resolution;
                if (validateMousePosition(x, y)) field[x, y] = false;
            }
        }

        private bool validateMousePosition(int x, int y)
        {
            return x >= 0 && y >= 0 && x < coll && y < rows;
        }
    }
}
