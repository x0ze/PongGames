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
        public Form1()
        {
            InitializeComponent();
        }

        private void solo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pong gamewindows = new Pong();
            gamewindows.Show();
        }

        private void Duo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pong gamewindows = new Pong();
            gamewindows.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menuepong menuegame = new Menuepong();
            menuegame.Show();
        }
    }
}
