﻿namespace PongGames
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Difficult = new System.Windows.Forms.Label();
            this.Normal = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Label();
            this.backMenu = new System.Windows.Forms.Label();
            this.sound = new System.Windows.Forms.Label();
            this.mute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Difficult
            // 
            this.Difficult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Difficult.AutoEllipsis = true;
            this.Difficult.BackColor = System.Drawing.Color.Black;
            this.Difficult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Difficult.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficult.ForeColor = System.Drawing.Color.White;
            this.Difficult.Location = new System.Drawing.Point(276, 296);
            this.Difficult.Name = "Difficult";
            this.Difficult.Size = new System.Drawing.Size(254, 83);
            this.Difficult.TabIndex = 4;
            this.Difficult.Text = "Difficult ";
            this.Difficult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Difficult.Click += new System.EventHandler(this.Difficult_Click);
            // 
            // Normal
            // 
            this.Normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Normal.AutoEllipsis = true;
            this.Normal.BackColor = System.Drawing.Color.Black;
            this.Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Normal.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal.ForeColor = System.Drawing.Color.White;
            this.Normal.Location = new System.Drawing.Point(276, 173);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(254, 83);
            this.Normal.TabIndex = 5;
            this.Normal.Text = "Normal";
            this.Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // Easy
            // 
            this.Easy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Easy.AutoEllipsis = true;
            this.Easy.BackColor = System.Drawing.Color.Black;
            this.Easy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Easy.Font = new System.Drawing.Font("Impact", 36F);
            this.Easy.ForeColor = System.Drawing.Color.White;
            this.Easy.Location = new System.Drawing.Point(276, 66);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(254, 83);
            this.Easy.TabIndex = 6;
            this.Easy.Text = "Easy";
            this.Easy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // backMenu
            // 
            this.backMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backMenu.Image = ((System.Drawing.Image)(resources.GetObject("backMenu.Image")));
            this.backMenu.Location = new System.Drawing.Point(745, 9);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(43, 44);
            this.backMenu.TabIndex = 7;
            this.backMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // sound
            // 
            this.sound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sound.Image = ((System.Drawing.Image)(resources.GetObject("sound.Image")));
            this.sound.Location = new System.Drawing.Point(-2, 1);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(76, 52);
            this.sound.TabIndex = 8;
            this.sound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // mute
            // 
            this.mute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mute.Image = ((System.Drawing.Image)(resources.GetObject("mute.Image")));
            this.mute.Location = new System.Drawing.Point(-2, 1);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(65, 52);
            this.mute.TabIndex = 9;
            this.mute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Difficult);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Difficult;
        private System.Windows.Forms.Label Normal;
        private System.Windows.Forms.Label Easy;
        private System.Windows.Forms.Label backMenu;
        private System.Windows.Forms.Label sound;
        private System.Windows.Forms.Label mute;
    }
}