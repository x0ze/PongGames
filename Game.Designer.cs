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
            this.outLeft = new PongGames.picturebox();
            this.outRight = new PongGames.picturebox();
            this.ball = new PongGames.picturebox();
            this.sideUp = new PongGames.picturebox();
            this.sideDown = new PongGames.picturebox();
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
            ((System.ComponentModel.ISupportInitialize)(this.outLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pad1
            // 
            this.pad1.BackColor = System.Drawing.Color.LimeGreen;
            this.pad1.Location = new System.Drawing.Point(37, 134);
            this.pad1.Name = "pad1";
            this.pad1.Size = new System.Drawing.Size(22, 161);
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
            this.pad2.Location = new System.Drawing.Point(879, 134);
            this.pad2.Name = "pad2";
            this.pad2.Size = new System.Drawing.Size(22, 161);
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
            this.pictureBox2.Location = new System.Drawing.Point(477, 59);
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
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.outRight.Location = new System.Drawing.Point(923, -4);
            this.outRight.Name = "outRight";
            this.outRight.Size = new System.Drawing.Size(23, 507);
            this.outRight.TabIndex = 14;
            this.outRight.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ball.Location = new System.Drawing.Point(451, 209);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 13;
            this.ball.TabStop = false;
            // 
            // sideUp
            // 
            this.sideUp.Location = new System.Drawing.Point(-6, -3);
            this.sideUp.Name = "sideUp";
            this.sideUp.Size = new System.Drawing.Size(952, 10);
            this.sideUp.TabIndex = 16;
            this.sideUp.TabStop = false;
            // 
            // sideDown
            // 
            this.sideDown.Location = new System.Drawing.Point(-6, 493);
            this.sideDown.Name = "sideDown";
            this.sideDown.Size = new System.Drawing.Size(952, 10);
            this.sideDown.TabIndex = 17;
            this.sideDown.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 501);
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
            this.Name = "Pong";
            this.Text = "PongGames";
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
            ((System.ComponentModel.ISupportInitialize)(this.outLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideDown)).EndInit();
            this.ResumeLayout(false);

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
        private picturebox ball;
        private picturebox outRight;
        private picturebox outLeft;
        private picturebox sideUp;
        private picturebox sideDown;
    }
}

