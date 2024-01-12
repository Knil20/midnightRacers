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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SecretScreen1());
        }
        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;

                f = current.FindForm();

                f.Controls.Remove(current);
            }

            f.Controls.Add(next);
            next.Focus();

        }

        
    }
}
