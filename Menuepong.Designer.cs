namespace PongGames
{
    partial class Menuepong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuepong));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solo = new System.Windows.Forms.Label();
            this.duo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 150);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Crimson;
            this.Exit.Location = new System.Drawing.Point(275, 288);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(254, 79);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Start.AutoEllipsis = true;
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Lime;
            this.Start.Location = new System.Drawing.Point(275, 177);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(254, 79);
            this.Start.TabIndex = 3;
            this.Start.Text = "start";
            this.Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(744, -5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 61);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // solo
            // 
            this.solo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.solo.AutoEllipsis = true;
            this.solo.BackColor = System.Drawing.Color.Black;
            this.solo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solo.ForeColor = System.Drawing.Color.White;
            this.solo.Location = new System.Drawing.Point(321, 256);
            this.solo.Name = "solo";
            this.solo.Size = new System.Drawing.Size(76, 31);
            this.solo.TabIndex = 7;
            this.solo.Text = "Solo";
            this.solo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solo.Click += new System.EventHandler(this.solo_Click);
            // 
            // duo
            // 
            this.duo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.duo.AutoEllipsis = true;
            this.duo.BackColor = System.Drawing.Color.Gray;
            this.duo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duo.ForeColor = System.Drawing.Color.White;
            this.duo.Location = new System.Drawing.Point(403, 256);
            this.duo.Name = "duo";
            this.duo.Size = new System.Drawing.Size(76, 31);
            this.duo.TabIndex = 8;
            this.duo.Text = "Duo";
            this.duo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.duo.Click += new System.EventHandler(this.duo_Click);
            // 
            // Menuepong
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.duo);
            this.Controls.Add(this.solo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menuepong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu pong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label solo;
        private System.Windows.Forms.Label duo;
    }
}