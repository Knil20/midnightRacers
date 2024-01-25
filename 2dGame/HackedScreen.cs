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

namespace _2dGame
{
    public partial class HackedScreen : UserControl
    {
        SoundPlayer ahh = new SoundPlayer(Properties.Resources.jumpscare);

        public HackedScreen()
        {
            InitializeComponent();
            SecretScreen5.hackedMusic.Stop();
            ahh.Play();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            SecretLoadingScreen.hacked = false;
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
