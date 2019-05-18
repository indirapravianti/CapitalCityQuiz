using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapitalCityQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PlayerNameInput playername = new PlayerNameInput();
            playername.Show();
        }

        private void btnHighscore_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Highscore highscore = new Highscore();
            highscore.Show();
        }
    }
}
