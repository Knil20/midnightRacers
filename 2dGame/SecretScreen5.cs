﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Threading;
using System.IO;

namespace _2dGame
{
    public partial class SecretScreen5 : UserControl
    {
        Player hero;

        string direction = "right";

        SolidBrush heroBrush = new SolidBrush(Color.BlueViolet);
        SolidBrush roadBrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush rainBrush = new SolidBrush(Color.Navy);
        SolidBrush drivewayBrush = new SolidBrush(Color.Gray);
        SolidBrush houseBrush = new SolidBrush(Color.DarkRed);
        SolidBrush roofBrush = new SolidBrush(Color.Sienna);

        Rectangle secRec1 = new Rectangle(0, 350, 600, 125);
        Rectangle secRec2 = new Rectangle(300, 175, 125, 175);
        Rectangle secRec3 = new Rectangle(275, 0, 400, 175);
        Rectangle secRec4 = new Rectangle(260, 0, 430, 5);

        Random randGen = new Random();
        int randValue = 0;

        List<Rectangle> rain = new List<Rectangle>();

        int rainSize = 6;
        int rainSpeedY = 10;
        int rainSpeedX = -10;

        public static System.Windows.Media.MediaPlayer hackedMusic = new System.Windows.Media.MediaPlayer();

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        Boolean safe = false;

        public SecretScreen5()
        {
            InitializeComponent();



            secretTimer5.Start();

            if (SecretLoadingScreen.hacked == false)
            {
                hero = new Player(0, 400, 4, 4);
            }
            else
            {
                hackedMusic.Open(new Uri(Application.StartupPath + "/Resources/1-10. Alchemists Fantasy.wav"));
                hackedMusic.MediaEnded += new EventHandler(secretMusic_MediaEnded);
                hackedMusic.Play();

                hero = new Player(325, 200, 4, 4);
                direction = "down";

                this.BackColor = Color.Black;

                roadBrush.Color = Color.Black;
                houseBrush.Color = Color.Black;
                roofBrush.Color = Color.Black;
                drivewayBrush.Color = Color.Black;
                rainBrush.Color = Color.Lime;

                rainSpeedY *= -1;
                rainSpeedX = 0;


                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox23.Visible = false;
                pictureBox24.Visible = false;
                pictureBox25.Visible = false;
            }

        }

        private void SecretScreen5_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
            }
        }

        private void SecretScreen5_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
            }
        }

        private void secretTimer5_Tick(object sender, EventArgs e)
        {
            //Move hero
            if (leftArrowDown && hero.x > 0)
            {
                direction = ("left");
                Collision();
                hero.Move("left");
            }
            else if (rightArrowDown && hero.x < this.Width - hero.width)
            {
                direction = ("right");
                Collision();
                hero.Move("right");
            }
            else if (upArrowDown && hero.y > 0)
            {
                direction = ("up");
                Collision();
                hero.Move("up");
            }
            else if (downArrowDown && hero.y < this.Height - hero.height)
            {
                direction = ("down");
                Collision();
                hero.Move("down");
            }


            for (int i = 0; i < rain.Count; i++)
            {
                if (SecretLoadingScreen.hacked == false)
                {
                    int y = rain[i].Y + rainSpeedY;
                    int x = rain[i].X + rainSpeedX;
                    rain[i] = new Rectangle(x, y, rainSize, rainSize);
                }
                else
                {
                    randValue = randGen.Next(1, 3);

                    if (randValue > 1)
                    {
                        rainSpeedY *= -1;

                        int y = rain[i].Y + rainSpeedY;
                        int x = rain[i].X + rainSpeedX;
                        rain[i] = new Rectangle(x, y, rainSize, rainSize);
                    }
                    else
                    {
                        int y = rain[i].Y + rainSpeedY;
                        int x = rain[i].X + rainSpeedX;
                        rain[i] = new Rectangle(x, y, rainSize, rainSize);
                    }
                }

            }

            //generate new raindrops

            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 0, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 0, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 0, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 100, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 200, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 300, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 400, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 500, rainSize, rainSize));
            rain.Add(new Rectangle(randGen.Next(0, 1300 - rainSize), 500, rainSize, rainSize));


            //remove raindrops
            for (int i = 0; i < rain.Count; i++)
            {
                if (rain[i].Y >= this.Height || rain[i].Y <= 0)
                {
                    rain.RemoveAt(i);
                }

            }

            if (SecretLoadingScreen.hacked == true)
            {
                for (int i = 0; i < rain.Count; i++)
                {
                    if (rain[i].IntersectsWith(secRec1))
                    {
                        rain.RemoveAt(i);
                    }
                    if (rain[i].IntersectsWith(secRec2))
                    {
                        rain.RemoveAt(i);
                    }

                }
            }



            Refresh();
        }

        private void SecretScreen5_Paint(object sender, PaintEventArgs e)
        {
            //drawing the road
            e.Graphics.FillRectangle(roadBrush, secRec1);
            e.Graphics.FillRectangle(drivewayBrush, secRec2);
            e.Graphics.FillRectangle(houseBrush, secRec3);
            e.Graphics.FillRectangle(roofBrush, secRec4);


            if (direction == "up")
            {
                int tempX = hero.x;
                int tempY = hero.y;

                e.Graphics.TranslateTransform(hero.x + hero.width - 55, hero.y + hero.height + 30);
                e.Graphics.RotateTransform(270);

                hero.x = 0;
                hero.y = 0;

                e.Graphics.DrawImage(Properties.Resources.CarImage, hero.x, hero.y, hero.width, hero.height);
                e.Graphics.ResetTransform();

                hero.x = tempX;
                hero.y = tempY;

            }
            else if (direction == "down")
            {
                int tempX = hero.x;
                int tempY = hero.y;

                e.Graphics.TranslateTransform(hero.x + hero.width - 25, hero.y + hero.height - 60);
                e.Graphics.RotateTransform(90);

                hero.x = 0;
                hero.y = 0;

                e.Graphics.DrawImage(Properties.Resources.CarImage, hero.x, hero.y, hero.width, hero.height);
                e.Graphics.ResetTransform();

                hero.x = tempX;
                hero.y = tempY;

            }
            else if (direction == "left")
            {
                int tempX = hero.x;
                int tempY = hero.y;

                e.Graphics.TranslateTransform(hero.x + hero.width, hero.y + hero.height);
                e.Graphics.RotateTransform(180);

                hero.x = 0;
                hero.y = 0;

                e.Graphics.DrawImage(Properties.Resources.CarImage, hero.x, hero.y, hero.width, hero.height);
                e.Graphics.ResetTransform();

                hero.x = tempX;
                hero.y = tempY;

            }
            else if (direction == "right")
            {
                e.Graphics.DrawImage(Properties.Resources.CarImage, hero.x, hero.y, hero.width, hero.height);
            }

            if (hero.y <= 215 && SecretLoadingScreen.hacked == false)
            {
                e.Graphics.DrawImage(Properties.Resources.theGlitch, 400, 150, 100, 100);
            }

            for (int i = 0; i < rain.Count(); i++)
            {
                e.Graphics.FillEllipse(rainBrush, rain[i]);

            }

        }
        public void Collision()
        {
            Rectangle switchRec = new Rectangle(300, 200, 125, 5);
            Rectangle switchBackRec = new Rectangle(0, 400, 5, 125);
            Rectangle playerRec = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            if (switchRec.IntersectsWith(playerRec) && direction == "up" && SecretLoadingScreen.hacked == false)
            {
                Form1.ChangeScreen(this, new SecretLoadingScreen());
                secretTimer5.Enabled = false;
            }

            if (switchBackRec.IntersectsWith(playerRec) && direction == "left")
            {
                SecretScreen4.isBack = true;
                Form1.ChangeScreen(this, new SecretScreen4());
            }
            if (secRec1.IntersectsWith(playerRec) || secRec2.IntersectsWith(playerRec))
            {
                safe = true;
            }
            else
            {
                safe = false;
            }
            if (SecretLoadingScreen.hacked == true)
            {
                for (int i = 0; i < rain.Count; i++)
                {
                    try
                    {
                        if (rain[i].IntersectsWith(playerRec) && safe == false)
                        {
                            rain.RemoveAt(i);
                            Form1.ChangeScreen(this, new HackedScreen());
                            secretTimer5.Enabled = false;

                        }
                    }
                    catch
                    {
                            Form1.ChangeScreen(this, new HackedScreen());
                            secretTimer5.Enabled = false;
                    }
                    
                }
            }
        }
        private void secretMusic_MediaEnded(object sender, EventArgs e)
        {
            hackedMusic.Stop();
            hackedMusic.Play();
        }
    }
}
