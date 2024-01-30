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

        private void Menuepong_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Pong gamewindows = new Pong();
            gamewindows.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Settings gamesettings = new Settings(); 
            gamesettings.Show();
        }
    }
}
