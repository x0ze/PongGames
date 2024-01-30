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
            ((System.ComponentModel.ISupportInitialize)(this.pad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad2)).BeginInit();
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
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pad2);
            this.Controls.Add(this.pad1);
            this.Name = "Pong";
            this.Text = "PongGames";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pad2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pad1;
        private System.Windows.Forms.Timer movement;
        private System.Windows.Forms.PictureBox pad2;
    }
}

