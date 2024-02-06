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
        bool upLeft, downLeft, upRight, downRight, right, left, upBall, downBall;


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
                upLeft = true;
            }
            if (e.KeyCode == Keys.S)
            {
                downLeft = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                upRight = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                downRight = true;
            }
        }

        private void MoveEvent(object sender, EventArgs e)
        {
            if (upLeft == true && pad1.Top > 0)
            {
                pad1.Top -= speed;
            }
            if (downLeft == true && pad1.Top < 340)
            {
                pad1.Top += speed;
            }
            if (upRight == true && pad2.Top > 0)
            {
                pad2.Top -= speed;
            }
            if (downRight == true && pad2.Top < 340)
            {
                pad2.Top += speed;
            }
            if (ball.Bounds.IntersectsWith(pad1.Bounds)) //Rebound of the ball on the left pad
            {
                left = false;
                right = true;
                if (upLeft == true)
                {
                    upBall = true;
                    downBall = true;
                }
                if (downLeft == true)
                {
                    upBall = false;
                    downBall = true;
                }
            }
            if (ball.Bounds.IntersectsWith(pad2.Bounds)) //Rebound of the ball on the right pad
            {
                left = true;
                right = false;
                if (upRight == true)
                {
                    upBall = true;
                    downBall = true;
                }
                if (downRight == true)
                {
                    upBall = false;
                    downBall = true;
                }
            }
            if (left==true) //Ball move left
            {
                ball.Left -=speed;
                if (upBall == true)
                {
                    ball.Top -=speed;
                }
                if (downBall == true)
                {
                    ball.Top +=speed;
                }
            }
            if (right == true) //Ball move right
            {
                ball.Left += speed;
                if (upBall == true)
                {
                    ball.Top -= speed;
                }
                if (downBall == true)
                {
                    ball.Top += speed;
                }
            }
            if (ball.Bounds.IntersectsWith(sideUp.Bounds))
            {
                upBall= false;
                downBall = true;
            }
            if (ball.Bounds.IntersectsWith(sideDown.Bounds))
            {
                upBall = true;
                downBall = false;
            }
            if (ball.Bounds.IntersectsWith(outRight.Bounds) | ball.Bounds.IntersectsWith(outLeft.Bounds)) //Ball doesn't touch any pads (GameOver)
            {
                left = false;
                right = false;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                upLeft = false;
            }
            if (e.KeyCode == Keys.S)
            {
                downLeft = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                upRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                downRight = false;
            }
        }
    }
}
