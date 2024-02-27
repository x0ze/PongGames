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
    public partial class Form1 : Form
    {

        public Form1()                                                              // Initialize Forms (windows)
        {
            InitializeComponent();
        }

        private void solo_Click(object sender, EventArgs e)                         // Start solo mode on click
        {
            this.Hide();
            Pong gamewindows = new Pong();
            gamewindows.Show();
        }

        private void Duo_Click(object sender, EventArgs e)                          // Start duo mode on click
        {
            this.Hide();
            Pong gamewindows = new Pong();
            gamewindows.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)                     // Back to start Menu
        {
            this.Hide();
            Menuepong menuegame = new Menuepong();
            menuegame.Show();
        }
    }
}
