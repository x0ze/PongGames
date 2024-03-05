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
        public static bool easy, normal=true, difficult;
        public Settings()
        {
            InitializeComponent();
        }

        private void Difficult_Click(object sender, EventArgs e)
        {
           easy = false;
           normal = false;
           difficult = true;
        }

        private void Normal_Click(object sender, EventArgs e)
        {
            easy = false;
            normal = true;
            difficult = false;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label2.Show();
        }
    }
}
