using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PongGames
{
    public partial class Pong : Form
    {
        
        bool upLeft, downLeft, upRight, downRight, moveLeft, moveRight, right, left, upBall, downBall, gameOver = false, win;   // Initialize all boolean vars
        SoundPlayer onTouch = new SoundPlayer(@"..\..\ressources\bip.wav");                                                     // Initialize var for sounds
        SoundPlayer onGameOver = new SoundPlayer(@"..\..\ressources\gameover.wav");                                             // Initialize var for sounds
        SoundPlayer GTA = new SoundPlayer(@"..\..\ressources\musicGTA.wav");                                                    // Initialize var for sounds
        int scoreLeft = 0, scoreRight = 0, seconde = 0;                                                                         // Define var score to 0 on start
        int speed = 15;                                                                                                         // Speed of the Game on start
        int nbrRebounds;                                                                                                        // Number of rebounds on the Training wall (solo mode)

        private void Pong_Load(object sender, EventArgs e)                                                                      // Load game menu
        {
            gameover.Hide();                                                                                                    // Hide Game over
            Back_menu.Hide();                                                                                                   // Hide Menu
            Restart.Hide();                                                                                                     // Hide Restart
            Pause.Hide();                                                                                                       // Hide Pause
            label1.Hide();
            label2.Hide();
            password.Hide();
            if (Settings.difficult)                                                                                             // Difficult mode starting speed
                speed = 25;
            if (Settings.easy)                                                                                                  // Easy mode starting speed
                speed = 10;
        }

        private void Pause_Click(object sender, EventArgs e)                                                                    // Resume button
        {
                Timer.Start();
                movement.Start();
                Back_menu.Hide();
                Restart.Hide();
                Pause.Hide();
        }

        private void Back_menu_Click(object sender, EventArgs e)                                                                // In game back menu
        {
            this.Hide();                                    
            Menuepong form3 = new Menuepong();
            form3.Show();
        }

        private void Restart_Click(object sender, EventArgs e)                                                                  // Restart Game
        {
            this.Hide();
            Pong pong = new Pong();
            pong.Show();
        }

        private void speedUp(object sender, EventArgs e)                                                                        // LevelUp (SpeedUp every 30 sec)
        {
            if(Settings.normal)
                speed += 1;
            if (Settings.difficult)
                speed += 3;
            if (Settings.easy)
                speed = 10;

        }

        public Pong()                                                                                                           // Game Form (Windows)
        {
            Random random = new Random();                                                                                       // Starting player (random)
            int randomnumber = random.Next(1, 3);
            
            if (randomnumber == 1)
            {
                left = true;
                right = false;
             }                                                                                                                    
            else
            {
                right = true;
                left = false;
            }

            InitializeComponent();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)                                                                   // Key pressed
        {
            if (e.KeyCode == Keys.W)
                upLeft = true;
            if (e.KeyCode == Keys.S)
                downLeft = true;
            if (e.KeyCode == Keys.A)
                moveLeft = true;
            if (e.KeyCode == Keys.D)
                moveRight = true;
            if (e.KeyCode == Keys.Up)
                upRight = true;
            if (e.KeyCode == Keys.Down)
                downRight = true;
            if (gameOver == false)                                                                                              // Pause menu
            {
                if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Escape)
                {
                    Timer.Stop();   
                    movement.Stop();
                    Back_menu.Show();
                    Restart.Show();
                    Pause.Show();
                }
            }
            
        }
        private void KeyIsUp(object sender, KeyEventArgs e)                                                                     // Key not pressed
        {
            if (e.KeyCode == Keys.W)
                upLeft = false;
            if (e.KeyCode == Keys.S)
                downLeft = false;
            if (e.KeyCode == Keys.A)
                moveLeft = false;
            if (e.KeyCode == Keys.D)
                moveRight = false;
            if (e.KeyCode == Keys.Up)
                upRight = false;
            if (e.KeyCode == Keys.Down)
                downRight = false;
            if (e.KeyCode == Keys.Up)
                upRight = false;
            if (e.KeyCode == Keys.Down)
                downRight = false;
        }

        private void MoveEvent(object sender, EventArgs e)                                                                      // All movement in the game
        {
            if (upLeft && !pad1.Bounds.IntersectsWith(sideUp.Bounds))                                                   // Move pad1 on top
                pad1.Top -= speed;
            if (downLeft && !pad1.Bounds.IntersectsWith(sideDown.Bounds))                                               // Move pad1 on bottom
                pad1.Top += speed;
            if (Menuepong.cheat)                                                                                                // Cheat feature (pad1 can move left and right)
            {
                if (moveLeft && !pad1.Bounds.IntersectsWith(sideUp.Bounds) && !pad1.Bounds.IntersectsWith(outLeft.Bounds))
                    pad1.Left -= speed;
                if (moveRight && !pad1.Bounds.IntersectsWith(sideDown.Bounds) && !pad1.Bounds.IntersectsWith(outRight.Bounds))
                    pad1.Left += speed;
            }
            if (Menuepong.Solo)                                                                                                 // Solo mode
            {
                score1.Hide();
                pad2.Hide();
                wallTraining.Show();
            }
            if(Menuepong.Duo)                                                                                                   // Duo mode
            {
                Timertime.Hide();
                pad2.Show();
                wallTraining.Hide();
                if (upRight && !pad2.Bounds.IntersectsWith(sideUp.Bounds))                                              // Move pad2 on top
                    pad2.Top -= speed;
                if (downRight && !pad2.Bounds.IntersectsWith(sideDown.Bounds))
                    pad2.Top += speed;
            }

            if (ball.Bounds.IntersectsWith(pad1.Bounds))                                                                        // Rebound of the ball on the left pad
            {
                if (Settings.soundOn && !Menuepong.cheat)
                    onTouch.Play();                                                                                             // Play sound on touch
                left = false;
                right = true;
                if (upLeft)
                {
                    upBall = true;
                    downBall = false;
                }
                if (downLeft)
                {
                    upBall = false;
                    downBall = true;
                }
            }
            if (ball.Bounds.IntersectsWith(pad2.Bounds) && Menuepong.Duo || ball.Bounds.IntersectsWith(wallTraining.Bounds) && Menuepong.Solo)            // Rebound of the ball on the right pad
            {
                nbrRebounds += 1;
                if (Settings.soundOn)
                    onTouch.Play();                                                                                             // Play sound on touch                  
                left = true;
                right = false;
                if(Menuepong.Duo)
                {
                    if (upRight)
                    {
                        upBall = true;
                        downBall = false;
                    }
                    if (downRight)
                    {
                        upBall = false;
                        downBall = true;
                    }
                }
            }
            if (left)                                                                                                     // Ball move left
            {
                ball.Left -=speed;
                if (upBall)
                    ball.Top -=speed;
                if (downBall)
                    ball.Top +=speed;
            }
            if (right)                                                                                                  // Ball move right
            {
                ball.Left += speed;
                if (upBall)
                    ball.Top -= speed;
                if (downBall)
                    ball.Top += speed;
            }
            if (ball.Bounds.IntersectsWith(sideUp.Bounds))                                                                      // Rebound on the upper side of the game board
            {
                upBall= false;
                downBall = true;
            }
            if (ball.Bounds.IntersectsWith(sideDown.Bounds))                                                                    // Rebound on the bottom side of the game board
            {
                upBall = true;
                downBall = false;
            }
            if (ball.Bounds.IntersectsWith(outRight.Bounds) )                                                                   // Player Left scored
            {
                scoreLeft += 1;
                upBall = false;
                downBall = false;
                ball.Left = this.Width / 2;
                ball.Top = this.Height / 2;
            }
            if (ball.Bounds.IntersectsWith(outLeft.Bounds))                                                                     // Player Right scored
            {
                scoreRight += 1;
                upBall = false;
                downBall = false;
                ball.Left = this.Width/2;
                ball.Top = this.Height/2;
            }
            score1.Text = scoreLeft.ToString();                                                                                 // Show the Left player score
            score2.Text = scoreRight.ToString();                                                                                // Show the right player score
            if (scoreRight == 5 || scoreLeft == 5)                                                                              // Game over
            {
                Timer.Stop();
                movement.Stop();
                gameover.Show();
                Menuepong.cheat = false;
                if (Settings.soundOn)
                    onGameOver.Play();                                                                                          // Play game over sound
                Back_menu.Show();
                Restart.Show();
                gameOver = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            seconde += 1;
            Timertime.Text = seconde.ToString();
            if (nbrRebounds == 2 && Menuepong.Solo)                                                                             //Easter Egg
            {
                password.Show();
                string passwd = password.Text;
                label2.Show();
                label1.Show();
                movement.Stop();
                if (Settings.soundOn && win != true)
                {
                    GTA.Play();                                                                                                 // Play sound easter egg
                    win = true;
                }
                if (passwd == "Pablito")                                                                                        // Check password to enabled cheat mode
                {
                    Menuepong.cheat = true;                                                                                     // Enable cheat
                    this.Hide();
                    password.Hide();
                    Menuepong.Solo = false;
                    Menuepong.Duo = true;
                    Pong Game = new Pong();
                    Game.Show();
                    Timer.Stop();
                }
            }
        }
    }
}
