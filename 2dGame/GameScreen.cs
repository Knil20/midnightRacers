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
using System.Media;
using System.IO;

namespace _2dGame //Midnight Racers
{
    public partial class GameScreen : UserControl
    {

        Player hero;
        RoadLines lines = new RoadLines(0, 120, -5);

        int x, y;
        int xSpeed, ySpeed;
        int location;
        string direction, crColor;
        int time = 6000; //6000
        int colorValue = 0;
        Boolean isPaused = true;

        // public static SoundPlayer bgMusic = new SoundPlayer(Properties.Resources._240BitsPerMile);

        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, escDown;

        SolidBrush heroBrush = new SolidBrush(Color.BlueViolet);
        SolidBrush sideBrush = new SolidBrush(Color.Gray);
        SolidBrush carBrush = new SolidBrush(Color.DarkGreen);
        SolidBrush lineBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush bitBrush = new SolidBrush(Color.White);

        List<Car> cars = new List<Car>();
        List<RoadLines> roadLines = new List<RoadLines>();

        public static int points = 0;
        public static int multiple = 0;
        public static int speed = 0;
        public static int collision = 0;
        public static int penalty = 0;
        public static int timesHit = 0;

        public static Boolean criticalHit = false;
        public static Boolean hasStar = true;
        public static Boolean winLoad = false;
        public static Boolean loseLoad = false;
        public static Boolean menuLoad = false;
        public static Boolean resetLoad = false;
        public static Boolean secretLoad = false;


        Random randGen = new Random();
        Random randColor = new Random();
        System.Windows.Media.MediaPlayer bgMusic = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer staticEr = new System.Windows.Media.MediaPlayer();
        SoundPlayer glitch = new SoundPlayer(Properties.Resources.glitchError);

        

        Color bgColour = Color.FromArgb(0, 0, 0);

        public GameScreen()
        {
            InitializeComponent();

            //Start Game
            gameTimer.Start();

            staticEr.Open(new Uri(Application.StartupPath + "/Resources/tv-glitch-6245.wav"));
            staticEr.MediaEnded += new EventHandler(staticEr_MediaEnded);
            bgMusic.Open(new Uri(Application.StartupPath + "/Resources/1-14. 240 Bits Per Mile (1).wav"));
            bgMusic.MediaEnded += new EventHandler(bgMusic_MediaEnded);
            bgMusic.Play();

            points = 0;
            multiple = 0;
            speed = 0;
            timesHit = 0;
            criticalHit = false;
            winLoad = false;
            loseLoad = false;
            menuLoad = false;
            resetLoad = false;

            //Create Hero
            hero = new Player(100, 235, 4, 6);

            //Create and add Roadlines
            roadLines = new List<RoadLines>();

            RoadLines r = new RoadLines(800, 120, -5);
            roadLines.Add(r);

            RoadLines r2 = new RoadLines(800, 360, -5);
            roadLines.Add(r2);

            RoadLines rt1 = new RoadLines(0, 120, -5);
            roadLines.Add(rt1);

            RoadLines rb1 = new RoadLines(0, 360, -5);
            roadLines.Add(rb1);

            RoadLines rt2 = new RoadLines(200, 120, -5);
            roadLines.Add(rt2);

            RoadLines rb2 = new RoadLines(200, 360, -5);
            roadLines.Add(rb2);

            RoadLines rt3 = new RoadLines(400, 120, -5);
            roadLines.Add(rt3);

            RoadLines rb3 = new RoadLines(400, 360, -5);
            roadLines.Add(rb3);

            RoadLines rt4 = new RoadLines(600, 120, -5);
            roadLines.Add(rt4);

            RoadLines rb4 = new RoadLines(600, 360, -5);
            roadLines.Add(rb4);

            //assigning locations and speed and adding the first car
            location = randGen.Next(1, 5);

            x = 800;

            if (location == 1)
            {
                y = randGen.Next(40, 90);
                xSpeed = -2;
                direction = "left";
            }
            else if (location == 2)
            {
                y = randGen.Next(140, 210);
                xSpeed = -2;
                direction = "left";
            }
            else if (location == 3)
            {
                y = randGen.Next(270, 330);
                xSpeed = -8;
                direction = "right";
            }
            else if (location == 4)
            {
                y = randGen.Next(380, 420);
                xSpeed = -8;
                direction = "right";
            }

            Car enemy = new Car(x, y, xSpeed, ySpeed, direction, crColor);
            cars.Add(enemy);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                case Keys.Escape:
                    escDown = true;
                    if (escDown == true && isPaused == true)
                    {
                        isPaused = false; 
                        gameTimer.Stop();
                        pauseLabel.Visible = true;
                        pauseMenuButton.Visible = true;
                        restartButton.Visible = true;
                        quitButton.Visible = true;
                    }
                    else
                    {
                        isPaused = true;
                        gameTimer.Start();
                        pauseLabel.Visible = false;
                        pauseMenuButton.Visible = false;
                        restartButton.Visible = false;
                        quitButton.Visible = false;
                    }
                        break;
                case Keys.Down:
                    if (speed <= 0 && multiple > 0)
                    {
                        speed++;
                        multiple--;
                    }
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
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
                case Keys.Escape:
                    break;
                case Keys.Down:
                    break;
                    
            }
        }

        private void bgMusic_MediaEnded(object sender, EventArgs e)
        {
            //Restart background music
            bgMusic.Stop();
            bgMusic.Play();
        }
        private void staticEr_MediaEnded(object sender, EventArgs e)
        {
            //Restart static noise
            staticEr.Stop();
            staticEr.Play();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Move hero
            if (leftArrowDown && hero.x > 0)
            {
                hero.Move("left");
            }
            else if (rightArrowDown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
            }

            if (upArrowDown && hero.y > 0)
            {
                hero.Move("up");
            }
            else if (downArrowDown && hero.y < this.Height - hero.height)
            {
                hero.Move("down");
            }

            //Subtract time from timer
            time--;

            //assigning locations and speed and adding the cars
            if (cars[cars.Count - 1].x < 600)
            {
                location = randGen.Next(1, 5);
                
                x = 800;

                if (location == 1)
                {
                    y = randGen.Next(40, 90);
                    xSpeed = -2;
                    direction = "left";
                }
                else if (location == 2)
                {
                    y = randGen.Next(140, 210);
                    xSpeed = -2;
                    direction = "left";
                }
                else if (location == 3)
                {
                    y = randGen.Next(270, 330);
                    xSpeed = -8;
                    direction = "right";
                }
                else if (location == 4)
                {
                    y = randGen.Next(380, 420);
                    xSpeed = -8;
                    direction = "right";
                }
                //pick random color for car
                int randCol = randColor.Next(1, 7);
                if(randCol == 1)
                {
                    crColor = "White";
                }
                if (randCol == 2)
                {
                    crColor = "Gray";
                }
                if (randCol == 3)
                {
                    crColor = "DarkGray";
                }
                if (randCol == 4)
                {
                    crColor = "DarkBlue";
                }
                if (randCol == 5)
                {
                    crColor = "DarkGreen";
                }
                if (randCol == 6)
                {
                    crColor = "DarkRed";
                }
                Car enemy = new Car(x, y, xSpeed, ySpeed, direction, crColor);
                cars.Add(enemy);

            }

            //creating roadlines
            if (roadLines[roadLines.Count - 1].x < 600)
            {
                RoadLines r = new RoadLines(800, 120, -5);
                roadLines.Add(r);

                RoadLines r2 = new RoadLines(800, 360, -5);
                roadLines.Add(r2);
            }

            //moving the roadlines
            foreach (RoadLines r in roadLines)
            {
                r.LinesMove();
            }

            //speed cap
            if (speed >= -40)
            {
                if (time % 20 == 0)
                {
                    speed -= 1;
                    multiple += 1;
                }
            }
            //adding points
            if (speed <= -10)
            {
                points++;
            }
            //moving the cars
            foreach (Car c in cars)
            {
                c.Move();
                c.Collision(hero);

            }
            //changing the labels
            timeLabel.Text = $"Time = {time}";
            pointLabel.Text = $"Score = {points}";
            speedLabel.Text = "Speed = " + speed * -5 + " MPH";
            //removing cars and roadlines
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].x < -80)
                {
                    cars.RemoveAt(i);
                }
            }
            for (int i = 0; i < roadLines.Count; i++)
            {
                if (roadLines[i].x < -80)
                {
                    roadLines.RemoveAt(i);
                }
            }
            //changing background color
            if (time % 100 == 0)
            {
                if (colorValue < 50)
                {
                    colorValue++;
                    bgColour = Color.FromArgb(colorValue, colorValue, colorValue);
                }
            }
            //loss conditions
            if(criticalHit == true)
            {
                gameTimer.Stop();
                bgMusic.Stop();

                Refresh();
                Thread.Sleep(500);

                loseLoad = true;
                Form1.ChangeScreen(this, new LoadingScreen());
            }
            if(timesHit == 20)
            {
                gameTimer.Stop();
                bgMusic.Stop();

                Refresh();
                Thread.Sleep(500);

                loseLoad = true;
                Form1.ChangeScreen(this, new LoadingScreen());
            }

            
            //finish the game when timer runs out
            if (time == 0)
            {
                gameTimer.Stop();

                penalty = collision * -100;
                points += penalty;
                bgMusic.Stop();

                Refresh();
                Thread.Sleep(1000);

                staticEr.Stop();

                winLoad = true;
                Form1.ChangeScreen(this, new LoadingScreen());
            }
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //changing background
            this.BackColor = bgColour;
            
            //drawing sidelines
            e.Graphics.FillRectangle(sideBrush, 0, 240, 800, 20);
            e.Graphics.FillRectangle(sideBrush, 0, 0, 800, 20);
            e.Graphics.FillRectangle(sideBrush, 0, 480, 800, 20);

            //drawing the cars and roadlines
            foreach (Car c in cars)
            {
                e.Graphics.FillRectangle(c.wheelBrush, c.fWheels);
                e.Graphics.FillRectangle(c.wheelBrush, c.bWheels);
                e.Graphics.FillRectangle(c.bodyBrush, c.x, c.y, c.width, c.height);
                e.Graphics.FillRectangle(c.headLightBrush, c.headLight);
                e.Graphics.FillRectangle(c.headLightBrush, c.headLight2);
                e.Graphics.FillRectangle(c.tailLightBrush, c.tailLight);
                e.Graphics.FillRectangle(c.tailLightBrush, c.tailLight2);
                e.Graphics.FillRectangle(c.shieldBrush, c.windshield);
                e.Graphics.FillRectangle(c.shieldBrush, c.windshield2);

            }
            foreach (RoadLines r in roadLines)
            {
                e.Graphics.FillRectangle(lineBrush, r.x, r.y, r.width, r.height);

            }
            //drawing the player
            e.Graphics.FillRectangle(hero.wheelBrush, hero.fWheels);
            e.Graphics.FillRectangle(hero.wheelBrush, hero.bWheels);
            e.Graphics.FillRectangle(heroBrush, hero.x, hero.y, hero.width, hero.height);
            e.Graphics.FillRectangle(hero.headLightBrush, hero.headLight);
            e.Graphics.FillRectangle(hero.headLightBrush, hero.headLight2);
            e.Graphics.FillRectangle(hero.tailLightBrush, hero.tailLight);
            e.Graphics.FillRectangle(hero.tailLightBrush, hero.tailLight2);
            e.Graphics.FillRectangle(hero.shieldBrush, hero.windshield);
            e.Graphics.FillRectangle(hero.shieldBrush, hero.windshield2);

            //flashing the "Glitch" effect
            if(hasStar == false)
            {
                if (time == 5000 || time == 4000 || time == 4500 || time == 3000 || time == 3667 || time == 3334 || time == 2000 || time == 2750 || time == 2500 || time == 2250 || time == 1000 || time == 1100 || time == 1075 || time == 1050 || time == 1025)
                {
                    e.Graphics.FillRectangle(bitBrush, 0, 2, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 22, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 42, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 62, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 82, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 102, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 122, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 142, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 162, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 182, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 202, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 222, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 242, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 262, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 282, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 302, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 322, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 342, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 362, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 382, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 402, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 422, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 442, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 462, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 482, 800, 2);
                    glitch.Play();
                    points -= 10;

                }
                //permanently drawing the "Glitch" effect, playing sounds, changing colors
                if (time <= 1000)
                {
                    e.Graphics.FillRectangle(bitBrush, 0, 2, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 22, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 42, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 62, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 82, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 102, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 122, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 142, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 162, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 182, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 202, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 222, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 242, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 262, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 282, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 302, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 322, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 342, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 362, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 382, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 402, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 422, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 442, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 462, 800, 2);
                    e.Graphics.FillRectangle(bitBrush, 0, 482, 800, 2);

                    if (time <= 750)
                    {
                        bitBrush.Color = Color.Purple;
                        timeLabel.Text = "Time = ERROR";
                        bgMusic.Stop();
                        staticEr.Play();
                    }
                    if (time <= 500)
                    {
                        lineBrush.Color = Color.Purple;
                        sideBrush.Color = Color.Purple;
                        speedLabel.Text = "Speed = ERROR";
                    }
                    if (time <= 250)
                    {
                        heroBrush.Color = Color.Purple;
                        hero.wheelBrush.Color = Color.Purple;
                        hero.headLightBrush.Color = Color.Purple;
                        hero.tailLightBrush.Color = Color.Purple;
                        hero.shieldBrush.Color = Color.Purple;
                        pointLabel.Text = "Points = ERROR";

                        foreach (Car c in cars)
                        {
                            c.bodyBrush.Color = Color.Purple;
                            c.wheelBrush.Color = Color.Purple;
                            c.headLightBrush.Color = Color.Purple;
                            c.tailLightBrush.Color = Color.Purple;
                            c.shieldBrush.Color = Color.Purple;
                        }

                    }
                }
            }
            
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            bgMusic.Stop();
            staticEr.Stop();
            resetLoad = true;
            Form1.ChangeScreen(this, new LoadingScreen());
        }

        private void pauseMenuButton_Click(object sender, EventArgs e)
        {
            bgMusic.Stop();
            staticEr.Stop();
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
