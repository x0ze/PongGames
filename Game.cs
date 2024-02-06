using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGames
{
    public partial class Pong : Form
    {
        bool up1, down1, up2, down2, right, left;
        int speed = 10;
        public Pong()
        {
            left = true;
            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up1 = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down1 = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up2 = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                down2 = true;
            }
        }

        private void MoveEvent(object sender, EventArgs e)
        {
            if (up1 == true && pad1.Top > 0)
            {
                pad1.Top -= speed;
            }
            if (down1 == true && pad1.Top < 340)
            {
                pad1.Top += speed;
            }
            if (up2 == true && pad2.Top > 0)
            {
                pad2.Top -= speed;
            }
            if (down2 == true && pad2.Top < 340)
            {
                pad2.Top += speed;
            }
            if (ball.Bounds.IntersectsWith(pad1.Bounds))
            {
                left = false;
                right = true;
            }
            if (ball.Bounds.IntersectsWith(pad2.Bounds))
            {
                left = true;
                right = false;
            }
            if (left==true)
            {
                ball.Left -=speed;
            }
            if (right == true)
            {
                ball.Left += speed;
            }
            /*if (ball.Left > pad1.Left+24 && left == true)
            {
                ball.Left -= speed;
            }
            if (ball.Left == pad1.Left+24)
            {
                left = false;
                right = true;
            }
            if (ball.Left < pad2.Left - 25 && right == true)
            {
                ball.Left += speed;
            }
            if (ball.Left == pad2.Left - 25)
            {
                right = false;
                left = true;
            }
            */

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up1 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down1 = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up2 = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down2 = false;
            }
        }
    }
}
