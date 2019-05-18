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
    public partial class PlayerNameInput : Form
    {
        public static string Username;
        public PlayerNameInput()
        {
            InitializeComponent();
        }

        private void btnSubmitName_Click_1(object sender, EventArgs e)
        {
            Username = tbPlayerName.Text;
            Gamepage gamepage = new Gamepage();
            gamepage.Show();
            this.Close();
        }
    }
}
