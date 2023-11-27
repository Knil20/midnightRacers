using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2dGame
{
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();

            helpLabel.Text = "Welcome To Midnight Racers \n\nThe goal of the game is to get the highest score possible before the sun rises.\nYour character will speed up over time, and you have to be faster than 50MPH to earn points.\nBe careful though, if you collide with another car, your speed will drop back to 5MPH and cause a 100 point penalty.\n\nWASD to move.\nDown Arrow to slow down.";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
