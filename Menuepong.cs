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
        public static bool Solo = false;
        public static bool Duo = true;
        public Menuepong()
        {
            InitializeComponent();
            if (Solo)
            {
                solo.BackColor = Color.Gray;
                duo.BackColor = Color.Transparent;
            }
            if (Duo)
            {
                duo.BackColor = Color.Gray;
                solo.BackColor = Color.Transparent;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(Solo)
            {
                this.Hide();
                Pong Game = new Pong();
                Game.Show();
            }

            if (Duo)
            {
                this.Hide();
                Pong Game = new Pong();
                Game.Show();
            }
         
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settingswindows = new Settings();
            settingswindows.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void solo_Click(object sender, EventArgs e)
        {
            solo.BackColor = Color.Gray;
            duo.BackColor = Color.Transparent;
            Duo = false;
            Solo = true;
        }

        private void duo_Click(object sender, EventArgs e)
        {
            duo.BackColor = Color.Gray;
            solo.BackColor = Color.Transparent;
            Duo = true;  
            Solo = false;   
        }
    }
}
