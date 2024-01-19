﻿using System;
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
    public partial class SecretScreen3 : UserControl
    {
        Player hero;

        string direction = "down";

        SolidBrush heroBrush = new SolidBrush(Color.BlueViolet);
        SolidBrush roadBrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush rainBrush = new SolidBrush(Color.Navy);

        Rectangle secRec1 = new Rectangle(100, 0, 125, 300);
        Rectangle secRec2 = new Rectangle(100, 175, 500, 125);
        Rectangle secRec3 = new Rectangle(475, 175, 125, 400);

        Random randGen = new Random();
        int randValue = 0;

        List<Rectangle> rain = new List<Rectangle>();

        int rainSize = 6;
        int rainSpeedY = 10;
        int rainSpeedX = -10;
        int isMonster = 0;

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        public static Boolean isBack = false;

        Boolean safe = false;

        public SecretScreen3()
        {
            InitializeComponent();

            secretTimer3.Start();

            if (SecretLoadingScreen.hacked == false)
            {
                if (isBack == false)
                {
                    hero = new Player(125, 30, 4, 4);
                }
                else
                {
                    isMonster++;
                    hero = new Player(500, 450, 4, 4);
                    direction = "up";
                }
                
            }
            else
            {
                hero = new Player(500, 450, 4, 4);
                direction = "left";

                this.BackColor = Color.Black;

                roadBrush.Color = Color.Black;
                rainBrush.Color = Color.Lime;

                rainSpeedY *= -1;
                rainSpeedX = 0;

                isMonster++;
            }
            isBack = false;
        }

        private void SecretScreen3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void SecretScreen3_KeyUp(object sender, KeyEventArgs e)
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

        private void secretTimer3_Tick(object sender, EventArgs e)
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
                if (rain[i].Y >= this.Height)
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
                    if (rain[i].IntersectsWith(secRec3))
                    {
                        rain.RemoveAt(i);
                    }

                }
            }

            Refresh();
        }

        private void SecretScreen3_Paint(object sender, PaintEventArgs e)
        {
            //drawing the road
            e.Graphics.FillRectangle(roadBrush, secRec1);
            e.Graphics.FillRectangle(roadBrush, secRec2);
            e.Graphics.FillRectangle(roadBrush, secRec3);

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

            if (hero.y >= 450 && isMonster == 0)
            {
                e.Graphics.DrawImage(Properties.Resources.theGlitch, 450, 250, 100, 100);
            }

            for (int i = 0; i < rain.Count(); i++)
            {
                e.Graphics.FillEllipse(rainBrush, rain[i]);

            }
        }
        public void Collision()
        {
            Rectangle switchRec = new Rectangle(475, 495, 125, 5);
            Rectangle switchBackRec = new Rectangle(100, 0, 125, 5);
            Rectangle playerRec = new Rectangle(hero.x, hero.y, hero.width, hero.height);

            if (switchRec.IntersectsWith(playerRec) && direction == "down")
            {
                Form1.ChangeScreen(this, new SecretScreen4());
                secretTimer3.Enabled = false;
            }

            if (switchBackRec.IntersectsWith(playerRec) && direction == "up")
            {
                SecretScreen2.isBack = true;
                Form1.ChangeScreen(this, new SecretScreen2());
            }
            if (secRec1.IntersectsWith(playerRec) || secRec2.IntersectsWith(playerRec) || secRec3.IntersectsWith(playerRec))
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
                    if (rain[i].IntersectsWith(playerRec) && safe == false)
                    {
                        
                        Form1.ChangeScreen(this, new HackedScreen());
                        secretTimer3.Enabled = false;
                    }
                }
            }
        }
    }
}
