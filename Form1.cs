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
        int i;
        int timeLeft = 5;
        public Form1()
        {
            InitializeComponent();
            string trueAnswer = GetCountryName();
            labelQuestion.Text = "What is the capital city of " + trueAnswer + "?";
        }

        public string GetCountryName()
        {
            List<string> countryList = new List<string>();
            countryList = Country.GetCountryList();
            Random random = new Random();
            string countryName = countryList.ElementAt(random.Next(0, 251));
            return countryName;
        }

        public void setRadioButtonText(string correctCountry)
        {
            Random randomize = new Random();
            i = randomize.Next(1, 4);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
            }

            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's Up!";
            }
        }

    }
}
