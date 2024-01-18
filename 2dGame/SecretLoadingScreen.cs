using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _2dGame
{
    public partial class SecretLoadingScreen : UserControl
    {
        int time;

        public static Boolean hacked = false;

        public SecretLoadingScreen()
        {
            InitializeComponent();

            sLTimer.Start();

            SecretScreen1.secretMusic.Stop();
        }

        private void sLTimer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time % 3 == 0)
            {
                runLabel.Visible = false;
            }
            else if (time % 2 == 0)
            {
               runLabel.Visible = true;
            }

            if(time == 50)
            {
                runLabel.Text = "RUN BACK!!!";
            }

            if (time == 100)
            {
                hacked = true;
                Form1.ChangeScreen(this, new SecretScreen5());
                sLTimer.Enabled = false;
            }

            Refresh();
        }
    }
}
