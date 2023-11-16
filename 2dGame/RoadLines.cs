using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dGame
{
    internal class RoadLines
    {
        public int width = 80;
        public int height = 20;
        public int x, y, xSpeed;

        public RoadLines(int _x, int _y, int _xSpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;

        }

        public void LinesMove()
        {
            x += xSpeed - GameScreen.multiple;
        }
    }
}
