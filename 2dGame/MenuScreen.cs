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
    public partial class MenuScreen : UserControl
    {
        SoundPlayer menu = new SoundPlayer(Properties.Resources.menu);

        public MenuScreen()
        {
            InitializeComponent();

            menu.Play();
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
    }
}
