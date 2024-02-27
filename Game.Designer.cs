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
            this.sideDown = new PongGames.picturebox();
            this.sideUp = new PongGames.picturebox();
            this.outLeft = new PongGames.picturebox();
            this.outRight = new PongGames.picturebox();
            this.ball = new PongGames.picturebox();
            this.levelUp = new System.Windows.Forms.Timer(this.components);
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
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(477, 459);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 30);
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
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
            this.gameover.Location = new System.Drawing.Point(133, 60);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(711, 146);
            this.gameover.TabIndex = 20;
            this.gameover.Text = "GAME OVER";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameover.Click += new System.EventHandler(this.gameover_Click);
            // 
            // Back_menu
            // 
            this.Back_menu.BackColor = System.Drawing.Color.Transparent;
            this.Back_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_menu.ForeColor = System.Drawing.Color.Transparent;
            this.Back_menu.Location = new System.Drawing.Point(261, 181);
            this.Back_menu.Name = "Back_menu";
            this.Back_menu.Size = new System.Drawing.Size(443, 146);
            this.Back_menu.TabIndex = 21;
            this.Back_menu.Text = "Back to menu ";
            this.Back_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back_menu.Click += new System.EventHandler(this.Back_menu_Click);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Transparent;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Transparent;
            this.Restart.Location = new System.Drawing.Point(360, 293);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(252, 146);
            this.Restart.TabIndex = 22;
            this.Restart.Text = "Restart";
            this.Restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
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
            this.ball.Location = new System.Drawing.Point(477, 219);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 13;
            this.ball.TabStop = false;
            // 
            // levelUp
            // 
            this.levelUp.Enabled = true;
            this.levelUp.Interval = 30000;
            this.levelUp.Tick += new System.EventHandler(this.speedUp);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 501);
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
    }
}

