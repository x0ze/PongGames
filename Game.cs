﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PongGames
{
    public partial class Pong : Form
    {
        
        bool upLeft, downLeft, upRight, downRight, right, left, upBall, downBall;
        SoundPlayer onTouch = new SoundPlayer(@"..\..\ressources\bip.wav");
        

        private void Pong_Load(object sender, EventArgs e)
        {
            gameover.Hide();
            Back_menu.Hide();
            Restart.Hide();
        }

        private void Back_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuepong form3 = new Menuepong();
            form3.Show();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pong pong = new Pong();
            pong.Show();
        }

        private void speedUp(object sender, EventArgs e)
        {
            speed += 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();  
            form1.Show();
        }

        int scoreLeft = 0, scoreRight = 0;
        int speed = 15;
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
            if (upLeft == true && !pad1.Bounds.IntersectsWith(sideUp.Bounds))
            {
                pad1.Top -= speed;
            }
            if (downLeft == true && !pad1.Bounds.IntersectsWith(sideDown.Bounds))
            {
                pad1.Top += speed;
            }
            if (upRight == true && !pad2.Bounds.IntersectsWith(sideUp.Bounds))
            {
                pad2.Top -= speed;
            }
            if (downRight == true && !pad2.Bounds.IntersectsWith(sideDown.Bounds))
            {
                pad2.Top += speed;
            }
            if (ball.Bounds.IntersectsWith(pad1.Bounds)) //Rebound of the ball on the left pad
            {
                onTouch.Play();
                left = false;
                right = true;
                if (upLeft == true)
                {
                    upBall = true;
                    downBall = false;
                }
                if (downLeft == true)
                {
                    upBall = false;
                    downBall = true;
                }
            }
            if (ball.Bounds.IntersectsWith(pad2.Bounds)) //Rebound of the ball on the right pad
            {
                onTouch.Play();
                left = true;
                right = false;
                if (upRight == true)
                {
                    upBall = true;
                    downBall = false;
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
            if (ball.Bounds.IntersectsWith(outRight.Bounds) ) //
            {
                scoreLeft += 1;
                if(scoreLeft == 5)
                {
                    movement.Stop();
                    gameover.Show();
                    Back_menu.Show();
                    Restart.Show();
                }
                ball.Left = 480;
                ball.Top = 270;
            }
            if (ball.Bounds.IntersectsWith(outLeft.Bounds)) //
            {
                scoreRight += 1;
                if (scoreRight == 5)
                {
                    movement.Stop();
                    gameover.Show();
                    Back_menu.Show();
                    Restart.Show();
                }
                ball.Left = 480;
                ball.Top = 270;
            }
            score1.Text = scoreLeft.ToString();
            score2.Text = scoreRight.ToString();
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
