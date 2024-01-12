using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace _2dGame
{
    public partial class GameOverScreen : UserControl
    {

        int hSOne;

        SoundPlayer win = new SoundPlayer(Properties.Resources.winner);
        int newPoint;

        List<HighScore> highscores = new List<HighScore>();

        public GameOverScreen()
        {
            InitializeComponent();
            win.Play();

            pointTimer.Start();
            newPoint = 0;
        }

        private void pointTimer_Tick(object sender, EventArgs e)
        {
            if (newPoint < GameScreen.points)
            {
                newPoint += 5;
            }
            else
            {
                pointTimer.Stop();
                hSOne = newPoint;

                HighScore newHighScore = new HighScore(hSOne);
                highscores.Add(newHighScore);


                label7.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                showButton.Visible = true;
                button1.Visible = true;
            }
            scoreLabel.Text = $"Your Final Score Is \n {newPoint}";

            Refresh();
        }
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            pointTimer.Stop();
            win.Stop();
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            loadDB();

            try
            {
                if(highscores[0].hS1 >= highscores[1].hS1)
                {
                    highscoreLabel.Text = highscores[0].hS1 + "";
                }
                else
                {
                    highscoreLabel.Text = highscores[1].hS1 + "";
                }
            }
            catch
            {
                highscoreLabel.Text = "No Highscore Yet Silly";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveDB();

            Application.Exit();
        }

        public void loadDB()
        {
            int highscoreOne;

            XmlReader reader = XmlReader.Create("Resources/highScore.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    highscoreOne = Convert.ToInt32(reader.ReadString());

                    HighScore newHighScore = new HighScore(highscoreOne);
                    highscores.Add(newHighScore);
                }
            }
            reader.Close();
        }

        public void saveDB()
        {
            XmlWriter writer = XmlWriter.Create("Resources/highScore.xml", null);

            writer.WriteStartElement("HighScores");

            foreach (HighScore h in highscores)
            {
                writer.WriteStartElement("HighScore");

                writer.WriteElementString("highScore", Convert.ToString(h.hS1));

                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }


    }
}
