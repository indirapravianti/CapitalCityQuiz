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
        int countdown;
        int life = 3;
        public Form1()
        {
            InitializeComponent();
            Build();
        }

        public void Build()
        {
            string trueAnswer = GetCountryName();
            labelQuestion.Text = "What is the capital city of " + trueAnswer + "?";
            setRadioButtonText(trueAnswer);
            countdown = 7;
            InitializeTimer();
        }

        public string GetCountryName()
        {
            List<string> countryList = new List<string>();
            countryList = Country.GetCountryList();
            Random random = new Random();
            string countryName = countryList.ElementAt(random.Next(0, 250));
            return countryName;
        }

        public void setRadioButtonText(string correctCountry)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict = Country.GetCountryName();
            Random randomize = new Random();
            i = randomize.Next(1, 4);

            if(i == 1)
            {
                radioButton1.Text = dict[$"{correctCountry}"];
                radioButton2.Text = dict[$"{GetCountryName()}"];
                radioButton3.Text = dict[$"{GetCountryName()}"];
                radioButton4.Text = dict[$"{GetCountryName()}"];
            }
            else if(i == 2){
                radioButton1.Text = dict[$"{GetCountryName()}"];
                radioButton2.Text = dict[$"{correctCountry}"];
                radioButton3.Text = dict[$"{GetCountryName()}"];
                radioButton4.Text = dict[$"{GetCountryName()}"];
            }
            else if (i == 3)
            {
                radioButton1.Text = dict[$"{GetCountryName()}"];
                radioButton2.Text = dict[$"{GetCountryName()}"];
                radioButton3.Text = dict[$"{correctCountry}"];
                radioButton4.Text = dict[$"{GetCountryName()}"];
            }
            else if (i == 4)
            {
                radioButton1.Text = dict[$"{GetCountryName()}"];
                radioButton2.Text = dict[$"{GetCountryName()}"];
                radioButton3.Text = dict[$"{GetCountryName()}"];
                radioButton4.Text = dict[$"{correctCountry}"];
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeLabel.Text = "Time: " + countdown.ToString();
            countdown -= 1;
            if (countdown == -1)
            {
                timer1.Stop();
                life -= 1;
                if (life == 2)
                    heart3.Hide();
                else if (life == 1)
                    heart2.Hide();
                else if (life == 0)
                {
                    heart1.Hide();
                    MessageBox.Show("GAME OVER");
                }
                Build();
            }
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timeLabel.Text = "Time: " + countdown.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(i == 1 && radioButton1.Checked)
            {
                MessageBox.Show("YAY, correct!");
            }
            else if (i == 2 && radioButton2.Checked)
            {
                MessageBox.Show("YAY, correct!");
            }
            else if (i == 3 && radioButton3.Checked)
            {
                MessageBox.Show("YAY, correct!");
            }
            else if (i == 4 && radioButton4.Checked)
            {
                MessageBox.Show("YAY, correct!");
            }
            else
            {
                MessageBox.Show("OUCH! Wrong answer.");
                life -= 1;
                if (life == 2)
                    heart3.Hide();
                else if (life == 1)
                    heart2.Hide();
                else if (life == 0)
                {
                    heart1.Hide();
                    MessageBox.Show("GAME OVER");
                    Form1 form1 = new Form1();
                    form1.Close();
                }
            }
            Build();
        }
    }
}