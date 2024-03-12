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
using System.Drawing;

namespace PongGames
{
    public partial class Pong : Form
    {
        
        SoundPlayer onTouch = new SoundPlayer(@"..\..\ressources\bip.wav");                                                     // Initialize var for pad rebounds sound
        SoundPlayer onGameOver = new SoundPlayer(@"..\..\ressources\gameover.wav");                                             // Initialize var for Gameover sound
        SoundPlayer GTA = new SoundPlayer(@"..\..\ressources\musicGTA.wav");                                                    // Initialize var for easterEgg sound

        bool upLeft, downLeft, upRight, downRight, moveLeft, moveRight, right, left, upBall, downBall, gameOver = false, win;   // Initialize all boolean vars
        int scoreLeft = 0, scoreRight = 0, seconde = 0;                                                                         // Define var score to 0 on start
        int speed, easySpeed = 10, normalSpeed = 15, difficultSpeed = 25;                                                       // Speed of the Game on start
        int easyLevelUp = 0, normalLevelUp = 1, difficultLevelUp = 3;                                                           // LevelUp speed of the game according on difficulty mode
        int nbrRebounds;                                                                                                        // Number of rebounds on the Training wall (solo mode)
        int nbrReboundsForEasterEgg = 2;                                                                                        // Number of rebounds on the Training wall to release the easter egg (solo mode)

        public Pong()                                                                                                           // Game Form (Windows)
        {
            InitializeComponent();
        }

        private void Pong_Load(object sender, EventArgs e)                                                                      // Load game menu
        {
            RandomStart();
            gameover.Hide();                                                                                                    // Hide Game over
            Back_menu.Hide();                                                                                                   // Hide Menu
            Restart.Hide();                                                                                                     // Hide Restart
            Pause.Hide();                                                                                                       // Hide Pause
            label1.Hide();
            label2.Hide();
            password.Hide();
            if (Settings.normal)
                speed = normalSpeed;                                                                                            // Normal mode starting speed
            else if (Settings.easy)                                                                                             // Easy mode starting speed
                speed = easySpeed;
            else if (Settings.difficult)                                                                                        // Difficult mode starting speed
                speed = difficultSpeed;
        }

        private void RandomStart ()
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
            if (!gameOver && (e.KeyCode == Keys.Space || e.KeyCode == Keys.Escape))                                             // Pause menu
            {
                Timer.Stop();
                movement.Stop();
                Back_menu.Show();
                Restart.Show();
                Pause.Show();
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
            MovePads();
            SoloMode();
            DuoMode();
            BallMovement();
            Score();
            GameOver();
        }

        private void ReboundsCheck(object sender, EventArgs e)
        {
            ReboundsBall();
        }

        private void MovePads()
        {
            if (upLeft && !pad1.Bounds.IntersectsWith(sideUp.Bounds))                                                           // Move pad1 on top
                pad1.Top -= speed;
            if (downLeft && !pad1.Bounds.IntersectsWith(sideDown.Bounds))                                                       // Move pad1 on bottom
                pad1.Top += speed;
            Cheat();
        }

        private void SoloMode()
        {
            if (Menuepong.Solo)                                                                                                 // Solo mode
            {
                score1.Hide();
                pad2.Hide();
                wallTraining.Show();
            }
        }

        private void DuoMode()
        {
            if (Menuepong.Duo)                                                                                                  // Duo mode
            {
                Timertime.Hide();
                pad2.Show();
                wallTraining.Hide();
                if (upRight && !pad2.Bounds.IntersectsWith(sideUp.Bounds))                                                      // Move pad2 on top
                    pad2.Top -= speed;
                if (downRight && !pad2.Bounds.IntersectsWith(sideDown.Bounds))
                    pad2.Top += speed;
            }
        }

        private void ReboundsBall()
        {
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
                if (Menuepong.Duo)
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
            if (ball.Bounds.IntersectsWith(sideUp.Bounds))                                                                      // Rebound on the upper side of the game board
            {
                upBall = false;
                downBall = true;
            }
            if (ball.Bounds.IntersectsWith(sideDown.Bounds))                                                                    // Rebound on the bottom side of the game board
            {
                upBall = true;
                downBall = false;
            }
        }

        private void BallMovement()
        {
            if (left)                                                                                                           // Ball move left
            {
                ball.Left -= speed;
                if (upBall)
                    ball.Top -= speed;
                if (downBall)
                    ball.Top += speed;
            }
            if (right)                                                                                                          // Ball move right
            {
                ball.Left += speed;
                if (upBall)
                    ball.Top -= speed;
                if (downBall)
                    ball.Top += speed;
            }
        }

        private void Score()
        {
            if (ball.Bounds.IntersectsWith(outRight.Bounds))                                                                    // Player Left scored
            {
                scoreLeft++;
                upBall = downBall = false;
                ball.Location = new Point(this.Width / 2 - ball.Height * 2, this.Height / 2 - ball.Height * 2);
            }
            if (ball.Bounds.IntersectsWith(outLeft.Bounds))                                                                     // Player Right scored
            {
                scoreRight++;
                upBall = downBall = false;
                ball.Location = new Point(this.Width / 2 - ball.Height * 2, this.Height / 2 - ball.Height * 2);
            }
            score1.Text = scoreLeft.ToString();                                                                                 // Show the Left player score
            score2.Text = scoreRight.ToString();                                                                                // Show the right player score
        }

        private void GameOver()
        {
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
            EasterEgg();
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
            this.Close();
            Menuepong form3 = new Menuepong();
            form3.Show();
        }

        private void Restart_Click(object sender, EventArgs e)                                                                  // Restart Game
        {
            ResetGame();
        }
        private void ResetGame()
        {
            gameover.Hide();                                                                                                    // Hide Game over
            Back_menu.Hide();                                                                                                   // Hide Menu
            Restart.Hide();                                                                                                     // Hide Restart
            Pause.Hide();                                                                                                       // Hide Pause
            label1.Hide();
            label2.Hide();
            password.Hide();
            ball.Left = this.Width / 2 - ball.Height * 2;
            ball.Top = this.Height / 2 - ball.Height * 2;
            scoreLeft = 0;
            scoreRight = 0;
            nbrRebounds = 0;
            movement.Start();
            levelUp.Start();
            if (Menuepong.Solo)
            {
                seconde = 0;
                Timer.Start();
                Timertime.Text = seconde.ToString();
            }
            pad1.Top = this.Height / 2 - pad1.Height + 10;
            pad2.Top = this.Height / 2 - pad2.Height + 10;
            pad1.Left = 0 + 35;
            gameOver = false;
        }

        private void speedUp(object sender, EventArgs e)                                                                        // LevelUp (SpeedUp every 30 sec)
        {
            if(Settings.normal)
                speed += normalLevelUp;
            if (Settings.difficult)
                speed += difficultLevelUp;
            if (Settings.easy)
                speed += easyLevelUp;
        }

        private void EasterEgg()
        {
            if (nbrRebounds == nbrReboundsForEasterEgg && Menuepong.Solo)                                                       //Easter Egg
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

        private void Cheat()
        {
            if (Menuepong.cheat)                                                                                                // Cheat feature (pad1 can move left and right)
            {
                if (moveLeft && !pad1.Bounds.IntersectsWith(sideUp.Bounds) && !pad1.Bounds.IntersectsWith(outLeft.Bounds))
                    pad1.Left -= speed;
                if (moveRight && !pad1.Bounds.IntersectsWith(sideDown.Bounds) && !pad1.Bounds.IntersectsWith(outRight.Bounds))
                    pad1.Left += speed;
            }
        }
    }
}
