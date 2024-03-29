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
using Microsoft.Win32.SafeHandles;

namespace _2dGame
{
    public partial class MenuScreen : UserControl
    {
        SoundPlayer menu = new SoundPlayer(Properties.Resources.menu);

        public MenuScreen()
        {
            InitializeComponent();

            menu.Play();

            GameScreen.winLoad = false;
            GameScreen.loseLoad = false;
            GameScreen.menuLoad = false;
            GameScreen.resetLoad = false;
            GameScreen.secretLoad = false;

            if (GameScreen.foundSecret == true)
            {
                secretButton.Visible = true;
            }
            if (GameScreen.hasStar == true)
            {
                starBox.Visible = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            menu.Stop();
            GameScreen.menuLoad = true;
            Form1.ChangeScreen(this, new LoadingScreen());
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            menu.Stop();
            Application.Exit(); 
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            menu.Stop();
            Form1.ChangeScreen(this, new InstructionScreen());
        }

        private void secretButton_Click(object sender, EventArgs e)
        {
            menu.Stop();
            GameScreen.secretLoad = true;
            Form1.ChangeScreen(this, new LoadingScreen());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
