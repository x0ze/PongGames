using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongGames
{
    public partial class Settings : Form
    {
        public static bool easy, normal=true, difficult, soundon = true, soundoff;
        public Settings()
        {
            InitializeComponent();
            if(easy)
                Easy.ForeColor = Color.Green;

            if(normal)
                Normal.ForeColor = Color.Yellow;

            if(difficult)
                Difficult.ForeColor = Color.Red;
            
            if(soundon)
                label2.Show();

            if(soundoff)
                label3.Show();
        }

        private void Difficult_Click(object sender, EventArgs e)
        {
            Difficult.ForeColor = Color.Red;
            Normal.ForeColor = Color.White;
            Easy.ForeColor = Color.White;
            easy = false;
           normal = false;
           difficult = true;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            Difficult.ForeColor = Color.Red;
            Normal.ForeColor = Color.Yellow;
            Easy.ForeColor = Color.White;
            easy = false;
            normal = true;
            difficult = false;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Difficult.ForeColor = Color.White;
            Normal.ForeColor = Color.White;
            Easy.ForeColor = Color.Green;
            easy = true;
            normal = false;
            difficult = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuepong menuewindows = new Menuepong();
            menuewindows.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show();
            soundon = false;
            soundoff = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label2.Show();
            soundon = true;
            soundoff = false;
        }
    }
}
