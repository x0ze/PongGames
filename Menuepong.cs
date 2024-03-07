using PongGames.Properties;
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
    public partial class Menuepong : Form
    {
        public static bool Solo = false;                            // Solo mode not in favorite by default
        public static bool Duo = true;                              // Duo mode in favorite by default
        public static bool cheat = false;                           // Cheat mode disabled by default
        public Menuepong()
        {
            InitializeComponent();
            if (Solo)                                               // Solo mode button
            {
                solo.BackColor = Color.Gray;
                duo.BackColor = Color.Transparent;
            }
            if (Duo)                                                // Duo mode button
            {
                duo.BackColor = Color.Gray;
                solo.BackColor = Color.Transparent;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(Solo)                                                // Start solo game
            {
                this.Hide();
                Pong Game = new Pong();
                Game.Show();
            }

            if (Duo)                                                // Start duo game
            {
                this.Hide();
                Pong Game = new Pong();
                Game.Show();
            }
         
        }

        private void Exit_Click(object sender, EventArgs e)         // Exit the game
        {
            Environment.Exit(0);
        }

        private void settings_Click(object sender, EventArgs e)     // Settings menu
        {
            this.Hide();
            Settings settingswindows = new Settings();
            settingswindows.Show();
        }

        private void solo_Click(object sender, EventArgs e)         // Solo mode enabled
        {
            solo.BackColor = Color.Gray;
            duo.BackColor = Color.Transparent;
            Duo = false;
            Solo = true;
        }

        private void duo_Click(object sender, EventArgs e)          // Duo mode enabled
        {
            duo.BackColor = Color.Gray;
            solo.BackColor = Color.Transparent;
            Duo = true;  
            Solo = false;   
        }
      
    }
}
