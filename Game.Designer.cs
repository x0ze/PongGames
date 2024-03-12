namespace PongGames
{
    partial class Pong
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.pad1 = new System.Windows.Forms.PictureBox();
            this.movement = new System.Windows.Forms.Timer(this.components);
            this.pad2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.Back_menu = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Label();
            this.levelUp = new System.Windows.Forms.Timer(this.components);
            this.wallTraining = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Timertime = new System.Windows.Forms.Label();
            this.sideDown = new PongGames.picturebox();
            this.sideUp = new PongGames.picturebox();
            this.outLeft = new PongGames.picturebox();
            this.outRight = new PongGames.picturebox();
            this.ball = new PongGames.picturebox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // pad1
            // 
            this.pad1.BackColor = System.Drawing.Color.LimeGreen;
            this.pad1.Location = new System.Drawing.Point(37, 200);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(22, 75);
            this.pad1.TabIndex = 0;
            this.pad1.TabStop = false;
            // 
            // movement
            // 
            this.movement.Enabled = true;
            this.movement.Interval = 20;
            this.movement.Tick += new System.EventHandler(this.MoveEvent);
            // 
            // pad2
            // 
            this.pad2.BackColor = System.Drawing.Color.LimeGreen;
            this.pad2.Location = new System.Drawing.Point(879, 200);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(22, 75);
            this.pad2.TabIndex = 1;
            this.pad2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(477, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(477, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(477, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(477, 159);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 30);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(477, 209);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 30);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox7.Location = new System.Drawing.Point(477, 459);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 30);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(477, 409);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 30);
            this.pictureBox8.TabIndex = 11;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox9.Location = new System.Drawing.Point(477, 359);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 30);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox10.Location = new System.Drawing.Point(477, 309);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(15, 30);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox11.Location = new System.Drawing.Point(477, 259);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(15, 30);
            this.pictureBox11.TabIndex = 8;
            this.pictureBox11.TabStop = false;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score1.Location = new System.Drawing.Point(401, 10);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(31, 36);
            this.score1.TabIndex = 18;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score2.Location = new System.Drawing.Point(541, 9);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(31, 36);
            this.score2.TabIndex = 19;
            this.score2.Text = "0";
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.Transparent;
            this.gameover.Image = ((System.Drawing.Image)(resources.GetObject("gameover.Image")));
            this.gameover.Location = new System.Drawing.Point(367, 93);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(238, 269);
            this.gameover.TabIndex = 20;
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back_menu
            // 
            this.Back_menu.BackColor = System.Drawing.Color.Transparent;
            this.Back_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_menu.ForeColor = System.Drawing.Color.Transparent;
            this.Back_menu.Image = ((System.Drawing.Image)(resources.GetObject("Back_menu.Image")));
            this.Back_menu.Location = new System.Drawing.Point(201, 188);
            this.Back_menu.Name = "Back_menu";
            this.Back_menu.Size = new System.Drawing.Size(132, 115);
            this.Back_menu.TabIndex = 21;
            this.Back_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back_menu.Click += new System.EventHandler(this.Back_menu_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Transparent;
            this.Restart.Image = ((System.Drawing.Image)(resources.GetObject("Restart.Image")));
            this.Restart.Location = new System.Drawing.Point(626, 188);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(127, 129);
            this.Restart.TabIndex = 22;
            this.Restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // levelUp
            // 
            this.levelUp.Enabled = true;
            this.levelUp.Interval = 30000;
            this.levelUp.Tick += new System.EventHandler(this.speedUp);
            // 
            // wallTraining
            // 
            this.wallTraining.BackColor = System.Drawing.Color.SlateGray;
            this.wallTraining.Image = ((System.Drawing.Image)(resources.GetObject("wallTraining.Image")));
            this.wallTraining.Location = new System.Drawing.Point(879, -3);
            this.wallTraining.Name = "wallTraining";
            this.wallTraining.Size = new System.Drawing.Size(67, 506);
            this.wallTraining.TabIndex = 23;
            this.wallTraining.TabStop = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.Transparent;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.Location = new System.Drawing.Point(419, 192);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(135, 101);
            this.Pause.TabIndex = 24;
            this.Pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Timertime
            // 
            this.Timertime.AutoSize = true;
            this.Timertime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Timertime.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timertime.ForeColor = System.Drawing.Color.Aqua;
            this.Timertime.Location = new System.Drawing.Point(401, 9);
            this.Timertime.Name = "Timertime";
            this.Timertime.Size = new System.Drawing.Size(31, 36);
            this.Timertime.TabIndex = 25;
            this.Timertime.Text = "0";
            // 
            // sideDown
            // 
            this.sideDown.Location = new System.Drawing.Point(-6, 493);
            this.sideDown.Name = "sideDown";
            this.sideDown.Size = new System.Drawing.Size(952, 10);
            this.sideDown.TabIndex = 17;
            this.sideDown.TabStop = false;
            // 
            // sideUp
            // 
            this.sideUp.Location = new System.Drawing.Point(-6, -3);
            this.sideUp.Name = "sideUp";
            this.sideUp.Size = new System.Drawing.Size(952, 10);
            this.sideUp.TabIndex = 16;
            this.sideUp.TabStop = false;
            // 
            // outLeft
            // 
            this.outLeft.Location = new System.Drawing.Point(-6, -4);
            this.outLeft.Name = "outLeft";
            this.outLeft.Size = new System.Drawing.Size(23, 507);
            this.outLeft.TabIndex = 15;
            this.outLeft.TabStop = false;
            // 
            // outRight
            // 
            this.outRight.BackColor = System.Drawing.Color.Black;
            this.outRight.Location = new System.Drawing.Point(923, -4);
            this.outRight.Name = "outRight";
            this.outRight.Size = new System.Drawing.Size(23, 507);
            this.outRight.TabIndex = 14;
            this.outRight.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Yellow;
            this.ball.Location = new System.Drawing.Point(477, 240);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 13;
            this.ball.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-6, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(952, 507);
            this.label2.TabIndex = 30;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(258, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 103);
            this.label1.TabIndex = 28;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Location = new System.Drawing.Point(611, 172);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 31;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Timertime);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.wallTraining);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Back_menu);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.sideDown);
            this.Controls.Add(this.sideUp);
            this.Controls.Add(this.outLeft);
            this.Controls.Add(this.outRight);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PongGames";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pad1;
        private System.Windows.Forms.Timer movement;
        private System.Windows.Forms.PictureBox pad2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private picturebox outRight;
        private picturebox outLeft;
        private picturebox sideUp;
        private picturebox sideDown;
        private picturebox ball;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label Back_menu;
        private System.Windows.Forms.Label Restart;
        private System.Windows.Forms.Timer levelUp;
        private System.Windows.Forms.PictureBox wallTraining;
        private System.Windows.Forms.Label Pause;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label Timertime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
    }
}

