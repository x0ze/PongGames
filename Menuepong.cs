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
        public Menuepong()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pong Game = new Pong();
            Game.Show();
         
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
        }

        private void duo_Click(object sender, EventArgs e)
        {
            duo.BackColor = Color.Gray;
            solo.BackColor = Color.Transparent;
        }
    }
}
