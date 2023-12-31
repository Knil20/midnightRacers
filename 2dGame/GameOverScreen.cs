﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _2dGame
{
    public partial class GameOverScreen : UserControl
    {
        SoundPlayer win = new SoundPlayer(Properties.Resources.winner);
        int newPoint = 0;

        public GameOverScreen()
        {
            InitializeComponent();

            win.Play();
            pointTimer.Start();
            newPoint = 0;
        }

        private void pointTimer_Tick(object sender, EventArgs e)
        {
            if(newPoint < GameScreen.points)
            {
                newPoint += 5;
                
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


    }
}
