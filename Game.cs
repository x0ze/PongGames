using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGames
{
    public partial class Pong : Form
    {
        bool up, down;
        int speed = 10;
        public Pong()
        {
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
        }

        private void MoveEvent(object sender, EventArgs e)
        {
            if (up == true && pad1.Top > 0)
            {
                pad1.Top -= speed;
            }
            if (down == true && pad1.Top < 340)
            {
                pad1.Top += speed;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
        }
    }
}
