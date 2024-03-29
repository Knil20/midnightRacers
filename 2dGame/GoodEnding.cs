﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _2dGame
{
    public partial class GoodEnding : UserControl
    {
        public GoodEnding()
        {
            InitializeComponent();
            SecretScreen5.hackedMusic.Stop();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            wisdomLabel.Text += "When In The Deepest of Dark.";

            Thread.Sleep(4000);
            Refresh();

            wisdomLabel.Text += "\nThere is Always a Light That Will Shine.";

            Thread.Sleep(4000);
            Refresh();

            wisdomLabel.Text += "\nWell Done Hero";

            Thread.Sleep(4000);
            Refresh();

            wisdomLabel.Text += "\nYou've Escaped The Curse";

            Thread.Sleep(4000);
            Refresh();

            wisdomLabel.Text += "\n";

            Thread.Sleep(4000);
            Refresh();

            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
