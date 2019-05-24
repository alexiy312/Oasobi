using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keymove
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;
        int cp = Cursor.Position.X;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vx;
            label1.Left += vy;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    vx = -5;
                    vy = 0;
                    break;
                case Keys.S:
                    vx = 5;
                    vy = 0;
                    break;
                case Keys.A:
                    vy = -5;
                    vx = 0;
                    break;
                case Keys.D:
                    vy = 5;
                    vx = 0;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    vx = 0;
                    vy = 0;
                    break;
                case Keys.S:
                    vx = 0;
                    vy = 0;
                    break;
                case Keys.A:
                    vy = 0;
                    vx = 0;
                    break;
                case Keys.D:
                    vy = 0;
                    vx = 0;
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Location = new Point(Cursor.Position.X - 130, Cursor.Position.Y - 130);
        }
    }
}
