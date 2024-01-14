using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2dGame
{
    public partial class LoadingScreen: UserControl
    {
        int time;
        public LoadingScreen()
        {
            InitializeComponent();

            loadingTimer.Start();
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            time++;

            if(time % 3 == 0)
            {
                loadingLabel.Text = "Loading...";
            }
            else if (time % 2 == 0)
            {
                loadingLabel.Text = "Loading..";
            }
            else
            {
                loadingLabel.Text = "Loading.";
            }
            
            if (time % 25 == 0)
            {
                if (GameScreen.menuLoad == true)
                {
                    loadingTimer.Stop();    
                    Form1.ChangeScreen(this, new GameScreen());
                }
                else if (GameScreen.loseLoad == true)
                {
                    loadingTimer.Stop();
                    Form1.ChangeScreen(this, new LossScreen());
                }
                else if (GameScreen.resetLoad == true)
                {
                    loadingTimer.Stop();
                    Form1.ChangeScreen(this, new GameScreen());
                }
                else if (GameScreen.winLoad == true)
                {
                    loadingTimer.Stop();
                    Form1.ChangeScreen(this, new GameOverScreen());
                }
                else if (GameScreen.secretLoad == true)
                {
                    loadingTimer.Stop();
                    Form1.ChangeScreen(this, new SecretScreen1());
                }
            }
            

        }
    }
}
