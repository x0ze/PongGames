namespace PongGames
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
            this.Difficult = new System.Windows.Forms.Label();
            this.Normal = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Difficult
            // 
            this.Difficult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Difficult.AutoEllipsis = true;
            this.Difficult.BackColor = System.Drawing.Color.Black;
            this.Difficult.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficult.ForeColor = System.Drawing.Color.White;
            this.Difficult.Location = new System.Drawing.Point(276, 79);
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
            this.Normal.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal.ForeColor = System.Drawing.Color.White;
            this.Normal.Location = new System.Drawing.Point(276, 197);
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
            this.Easy.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Easy.ForeColor = System.Drawing.Color.White;
            this.Easy.Location = new System.Drawing.Point(276, 318);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(254, 83);
            this.Easy.TabIndex = 6;
            this.Easy.Text = "Easy";
            this.Easy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Normal);
            this.Controls.Add(this.Difficult);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Difficult;
        private System.Windows.Forms.Label Normal;
        private System.Windows.Forms.Label Easy;
    }
}