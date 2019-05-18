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
    public partial class Highscore : Form
    {
        private List<string> usernameList;
        private List<int> highscoreList;
        public Highscore()
        {
            InitializeComponent();
            string user = "";
            string score = "";
            int topScore = 0;
            int index = 0;
            AddPlayer();
            if(usernameList.Count() >= 5)
            {
                for(int j = 0; j < 5; j++)
                {
                    int k = highscoreList.Count();
                    for (int i = 0; i < k; i++)
                    {
                        if (highscoreList[i] > topScore)
                        {
                            topScore = highscoreList[i];
                            index = i;
                        }
                    }
                    user += usernameList[index] + "\n";
                    usernameList.RemoveAt(index);
                    score += Convert.ToString(topScore) + "\n";
                    highscoreList.RemoveAt(index);
                    topScore = 0;
                }
            }
            else
            {
                int x = highscoreList.Count();
                for(int j = 0; j < x; j++)
                {
                    for (int i = 0; i < highscoreList.Count(); i++)
                    {
                        if (highscoreList[i] > topScore)
                        {
                            topScore = highscoreList[i];
                            index = i;
                        }
                    }
                    user += usernameList[index] + "\n";
                    usernameList.RemoveAt(index);
                    score += Convert.ToString(topScore) + "\n";
                    highscoreList.RemoveAt(index);
                    topScore = 0;
                }
            }
            lblUsername.Text = user;
            lblScore.Text = score;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void AddPlayer()
        {
            using (var db = new UsernameModel())
            {
                usernameList = new List<string>();
                highscoreList = new List<int>();
                var query = from player in db.Tables select player;
                foreach (var item in query)
                {
                    usernameList.Add(item.Username);
                    highscoreList.Add(item.Score);
                }
            }
        }

    }
}
