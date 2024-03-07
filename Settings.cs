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
        public static bool easy, normal=true, difficult, soundOn = true; // Initialize all boolean vars in public static to be accessible in others forms

        public Settings()                                                // Buttons persistences
        {
            InitializeComponent();
            if(easy)
                Easy.ForeColor = Color.Green;
            if(normal)
                Normal.ForeColor = Color.Yellow;
            if(difficult)
                Difficult.ForeColor = Color.Red;
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

        private void Difficult_Click(object sender, EventArgs e)         // Diffcult color (red)
        {
            Difficult.ForeColor = Color.Red;
            Normal.ForeColor = Color.White;
            Easy.ForeColor = Color.White;
            easy = false;
            normal = false;
            difficult = true;
        }

        private void Normal_Click(object sender, EventArgs e)            // Normal color (yellow)
        {
            Difficult.ForeColor = Color.White;
            Normal.ForeColor = Color.Yellow;
            Easy.ForeColor = Color.White;
            easy = false;
            normal = true;
            difficult = false;
        }

        private void Easy_Click(object sender, EventArgs e)              // Easy color (green)
        {
            Difficult.ForeColor = Color.White;
            Normal.ForeColor = Color.White;
            Easy.ForeColor = Color.Green;
            easy = true;
            normal = false;
            difficult = false;
        }

        private void backMenu_Click(object sender, EventArgs e)          // Exit settings, return back to main menu
        {
            this.Hide();
            Menuepong menuewindows = new Menuepong();
            menuewindows.Show();
        }

        private void sound_Click(object sender, EventArgs e)             // Sound on button
        {
            soundOn = false;
            mute.Show();
            sound.Hide();
        }

        private void mute_Click(object sender, EventArgs e)              // Sound off / mute button
        {
            soundOn = true;
            mute.Hide();
            sound.Show();
        }
    }
}
