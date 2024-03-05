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
        public static bool easy, normal=true, difficult, soundOn = true;
        public Settings()
        {
            InitializeComponent();
            if(easy)
                Easy.ForeColor = Color.Green;

            if(normal)
                Normal.ForeColor = Color.Yellow;

            if(difficult)
                Difficult.ForeColor = Color.Red;
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
            Difficult.ForeColor = Color.White;
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
            if (!soundOn)
            {
                mute.Show();
                sound.Hide();
            }
            else
            {
                mute.Hide();
                sound.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuepong menuewindows = new Menuepong();
            menuewindows.Show();
        }

        private void sound_Click(object sender, EventArgs e)
        {
            soundOn = false;
            mute.Show();
            sound.Hide();
        }

        private void mute_Click(object sender, EventArgs e)
        {
            soundOn = true;
            mute.Hide();
            sound.Show();
        }
    }
}
