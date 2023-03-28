using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Square : Figure
    {

        public Square(int x,int y, char s)
        {
            points[0] = new Point(x, y, s);
            points[1] = new Point(x + 1, y, s);
            points[2] = new Point(x, y + 1, s);
            points[3] = new Point(x + 1, y + 1, s);
        }

    }
}
