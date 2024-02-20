namespace PongGames
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.solo = new System.Windows.Forms.Label();
            this.Duo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solo
            // 
            this.solo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.solo.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solo.ForeColor = System.Drawing.Color.White;
            this.solo.Location = new System.Drawing.Point(276, 92);
            this.solo.Name = "solo";
            this.solo.Size = new System.Drawing.Size(256, 134);
            this.solo.TabIndex = 0;
            this.solo.Text = "Solo";
            this.solo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.solo.Click += new System.EventHandler(this.solo_Click);
            // 
            // Duo
            // 
            this.Duo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Duo.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duo.ForeColor = System.Drawing.Color.White;
            this.Duo.Location = new System.Drawing.Point(276, 241);
            this.Duo.Name = "Duo";
            this.Duo.Size = new System.Drawing.Size(256, 134);
            this.Duo.TabIndex = 1;
            this.Duo.Text = "Duo";
            this.Duo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Duo.Click += new System.EventHandler(this.Duo_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(744, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 39);
            this.label2.TabIndex = 8;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Duo);
            this.Controls.Add(this.solo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label solo;
        private System.Windows.Forms.Label Duo;
        private System.Windows.Forms.Label label2;
    }
}