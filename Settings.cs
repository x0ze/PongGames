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
            mute.Visible = !soundOn;
            sound.Visible = soundOn;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Easy.ForeColor = Color.Green;                               // Easy color (green)
            Normal.ForeColor = Difficult.ForeColor = Color.White;       // Other difficulty color (white)
            (easy, normal, difficult) = (true, false, false);           // Set difficulty to easy
        }
        private void Normal_Click(object sender, EventArgs e)
        {
            Normal.ForeColor = Color.Yellow;                            // Normal color (yellow)
            Easy.ForeColor = Difficult.ForeColor = Color.White;         // Other difficulty color (white)
            (easy, normal, difficult) = (false, true, false);           // Set difficulty to normal

        }
        private void Difficult_Click(object sender, EventArgs e)         
        {
            Difficult.ForeColor = Color.Red;                            // Diffcult color (red)
            Normal.ForeColor = Easy.ForeColor = Color.White;            // Other difficulty color (white)
            (easy, normal, difficult) = (false, false, true);           // Set difficulty to difficult
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
