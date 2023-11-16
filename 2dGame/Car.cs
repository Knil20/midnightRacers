using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace _2dGame
{
    internal class Car
    {
        public int width = 80;
        public int height = 30;
        public int x, y, xSpeed, ySpeed;
        public string direction, color;

        public static SoundPlayer boom = new SoundPlayer(Properties.Resources.explosion);

        public SolidBrush headLightBrush = new SolidBrush(Color.Yellow);
        public SolidBrush tailLightBrush = new SolidBrush(Color.Red);
        public SolidBrush shieldBrush = new SolidBrush(Color.DeepSkyBlue);
        public SolidBrush wheelBrush = new SolidBrush(Color.Black);
        public SolidBrush bodyBrush = new SolidBrush(Color.DarkGreen);

        public Rectangle headLight;
        public Rectangle headLight2;
        public Rectangle tailLight;
        public Rectangle tailLight2;
        public Rectangle windshield;
        public Rectangle windshield2;
        public Rectangle fWheels;
        public Rectangle bWheels;



        public Car(int _x, int _y, int _xSpeed, int _ySpeed, string _direction, string _color)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            direction = _direction;
            color = _color; 

            if(direction == "left")
            {
                headLight = new Rectangle(x + width - 5, y + height - 5, 5, 5);
                headLight2 = new Rectangle(x + width - 5, y, 5, 5);
                tailLight = new Rectangle(x, y + height - 5, 5, 5);
                tailLight2 = new Rectangle(x, y, 5, 5);
                windshield = new Rectangle(x + width - 25, y + 2, 15, 26);
                windshield2 = new Rectangle(x + width - 70, y + 2, 10, 26);
                fWheels = new Rectangle(x + width - 25, y - 3, 15, 36);
                bWheels = new Rectangle(x + width - 70, y - 3, 15, 36);
            }
            else if(direction == "right")
            {
                headLight = new Rectangle(x, y + height - 5, 5, 5);
                headLight2 = new Rectangle(x, y, 5, 5);
                tailLight = new Rectangle(x + width - 5, y + height - 5, 5, 5);
                tailLight2 = new Rectangle(x + width - 5, y, 5, 5);
                windshield = new Rectangle(x + width - 65, y + 2, 15, 26);
                windshield2 = new Rectangle(x + width - 25, y + 2, 10, 26);
                fWheels = new Rectangle(x + width - 70, y - 3, 15, 36);
                bWheels = new Rectangle(x + width - 25, y - 3, 15, 36);
            }

            if (color == "White")
            {
                bodyBrush.Color = Color.White;

            }
            else if (color == "Gray")
            {
                bodyBrush.Color = Color.Gray;

            }
            else if (color == "DarkGray")
            {
                bodyBrush.Color = Color.DarkGray;

            }
            else if (color == "DarkBlue")
            {
                bodyBrush.Color = Color.DarkBlue;

            }
            else if (color == "DarkGreen")
            {
                bodyBrush.Color = Color.DarkGreen;

            }
            else if (color == "DarkRed")
            {
                bodyBrush.Color = Color.DarkRed;

            }

        }

        public void Move()
        {
            x += xSpeed + GameScreen.speed;
            int headX = headLight.X + xSpeed + GameScreen.speed;
            int headX2 = headLight2.X + xSpeed + GameScreen.speed;
            int tailX = tailLight.X + xSpeed + GameScreen.speed;
            int tailX2 = tailLight2.X + xSpeed + GameScreen.speed;
            int shieldX = windshield.X + xSpeed + GameScreen.speed;
            int shieldX2 = windshield2.X + xSpeed + GameScreen.speed;
            int fWheelX = fWheels.X + xSpeed + GameScreen.speed;
            int bWheelX = bWheels.X + xSpeed + GameScreen.speed;

            headLight = new Rectangle(headX, y + height - 5, 5, 5);
            headLight2 = new Rectangle(headX2, y, 5, 5);
            tailLight = new Rectangle(tailX, y + height - 5, 5, 5);
            tailLight2 = new Rectangle(tailX2, y, 5, 5);
            windshield = new Rectangle(shieldX, y + 2, 15, 26);
            windshield2 = new Rectangle(shieldX2, y + 2, 10, 26);
            fWheels = new Rectangle(fWheelX, y - 3, 15, 36);
            bWheels = new Rectangle(bWheelX, y - 3, 15, 36);

        }

        public void Collision(Player p)
        {
            Rectangle carRec = new Rectangle(x, y, width, height);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (carRec.IntersectsWith(playerRec))
            {
                ySpeed += 1000;
                y = ySpeed;

                boom.Play();

                GameScreen.speed = -1;
                GameScreen.multiple = 0;
                
            }
        }
    }
}
