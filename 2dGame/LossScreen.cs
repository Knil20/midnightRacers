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
    public partial class LossScreen : UserControl
    {
        public LossScreen()
        {
            InitializeComponent();

            Car.boom.Play();

            Thread.Sleep(200);
            Refresh();  

            Car.boom.Play();

            Thread.Sleep(200);
            Refresh();

            Car.boom.Play();

            Thread.Sleep(200);
            Refresh();

            Car.boom.Play();
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
