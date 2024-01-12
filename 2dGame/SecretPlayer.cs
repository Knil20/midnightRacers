using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2dGame
{
    internal class SecretPlayer
    {
        public int width = 80;
        public int height = 30;
        public int x, y, xSpeed, ySpeed;

        public SolidBrush headLightBrush = new SolidBrush(Color.Yellow);
        public SolidBrush tailLightBrush = new SolidBrush(Color.Red);
        public SolidBrush shieldBrush = new SolidBrush(Color.DeepSkyBlue);
        public SolidBrush wheelBrush = new SolidBrush(Color.Black);
        public SolidBrush wiperBrush = new SolidBrush(Color.Black);

        public Rectangle headLight;
        public Rectangle headLight2;
        public Rectangle tailLight;
        public Rectangle tailLight2;
        public Rectangle windshield;
        public Rectangle windshield2;
        public Rectangle fWheels;
        public Rectangle bWheels;



        public SecretPlayer(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;

            headLight = new Rectangle(x + width - 5, y + height - 5, 5, 5);
            headLight2 = new Rectangle(x + width - 5, y, 5, 5);
            tailLight = new Rectangle(x, y + height - 5, 5, 5);
            tailLight2 = new Rectangle(x, y, 5, 5);
            windshield = new Rectangle(x + width - 25, y + 2, 15, 26);
            windshield2 = new Rectangle(x + width - 70, y + 2, 10, 26);
            fWheels = new Rectangle(x + width - 25, y - 3, 15, 36);
            bWheels = new Rectangle(x + width - 70, y - 3, 15, 36);
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= xSpeed;
                int headX = headLight.X - xSpeed;
                int headX2 = headLight2.X - xSpeed;
                int tailX = tailLight.X - xSpeed;
                int tailX2 = tailLight2.X - xSpeed;
                int shieldX = windshield.X - xSpeed;
                int shieldX2 = windshield2.X - xSpeed;
                int fWheel = fWheels.X - xSpeed;
                int bWheel = bWheels.X - xSpeed;

                headLight = new Rectangle(headX, y + height - 5, 5, 5);
                headLight2 = new Rectangle(headX2, y, 5, 5);
                tailLight = new Rectangle(tailX, y + height - 5, 5, 5);
                tailLight2 = new Rectangle(tailX2, y, 5, 5);
                windshield = new Rectangle(shieldX, y + 2, 15, 26);
                windshield2 = new Rectangle(shieldX2, y + 2, 10, 26);
                fWheels = new Rectangle(fWheel, y - 3, 15, 36);
                bWheels = new Rectangle(bWheel, y - 3, 15, 36);
            }
            else if (direction == "right")
            {
                x += xSpeed;
                int headX = headLight.X + xSpeed;
                int headX2 = headLight2.X + xSpeed;
                int tailX = tailLight.X + xSpeed;
                int tailX2 = tailLight2.X + xSpeed;
                int shieldX = windshield.X + xSpeed;
                int shieldX2 = windshield2.X + xSpeed;
                int fWheel = fWheels.X + xSpeed;
                int bWheel = bWheels.X + xSpeed;

                headLight = new Rectangle(headX, y + height - 5, 5, 5);
                headLight2 = new Rectangle(headX2, y, 5, 5);
                tailLight = new Rectangle(tailX, y + height - 5, 5, 5);
                tailLight2 = new Rectangle(tailX2, y, 5, 5);
                windshield = new Rectangle(shieldX, y + 2, 15, 26);
                windshield2 = new Rectangle(shieldX2, y + 2, 10, 26);
                fWheels = new Rectangle(fWheel, y - 3, 15, 36);
                bWheels = new Rectangle(bWheel, y - 3, 15, 36);
            }

            if (direction == "up")
            {
                y -= ySpeed;
                int headY = headLight.Y - ySpeed;
                int headY2 = headLight2.Y - ySpeed;
                int tailY = tailLight.Y - ySpeed;
                int tailY2 = tailLight2.Y - ySpeed;
                int shieldY = windshield.Y - ySpeed;
                int shieldY2 = windshield2.Y - ySpeed;
                int fWheel = fWheels.Y - ySpeed;
                int bWheel = bWheels.Y - ySpeed;

                headLight = new Rectangle(x + width - 5, headY, 5, 5);
                headLight2 = new Rectangle(x + width - 5, headY2, 5, 5);
                tailLight = new Rectangle(x, tailY, 5, 5);
                tailLight2 = new Rectangle(x, tailY2, 5, 5);
                windshield = new Rectangle(x + width - 25, shieldY, 15, 26);
                windshield2 = new Rectangle(x + width - 70, shieldY2, 10, 26);
                fWheels = new Rectangle(x + width - 25, fWheel, 15, 36);
                bWheels = new Rectangle(x + width - 70, bWheel, 15, 36);
            }
            else if (direction == "down")
            {
                y += ySpeed;
                int headY = headLight.Y + ySpeed;
                int headY2 = headLight2.Y + ySpeed;
                int tailY = tailLight.Y + ySpeed;
                int tailY2 = tailLight2.Y + ySpeed;
                int shieldY = windshield.Y + ySpeed;
                int shieldY2 = windshield2.Y + ySpeed;
                int fWheel = fWheels.Y + ySpeed;
                int bWheel = bWheels.Y + ySpeed;

                headLight = new Rectangle(x + width - 5, headY, 5, 5);
                headLight2 = new Rectangle(x + width - 5, headY2, 5, 5);
                tailLight = new Rectangle(x, tailY, 5, 5);
                tailLight2 = new Rectangle(x, tailY2, 5, 5);
                windshield = new Rectangle(x + width - 25, shieldY, 15, 26);
                windshield2 = new Rectangle(x + width - 70, shieldY2, 10, 26);
                fWheels = new Rectangle(x + width - 25, fWheel, 15, 36);
                bWheels = new Rectangle(x + width - 70, bWheel, 15, 36);

            }
        }
    }
}
