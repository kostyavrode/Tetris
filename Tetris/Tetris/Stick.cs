using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick : Figure
    {

        public Stick(int x, int y, char s)
        {
            points[0] = new Point(x, y, s);
            points[1] = new Point(x, y+1, s);
            points[2] = new Point(x, y + 2, s);
            points[3] = new Point(x, y + 3, s);
        }
    }
}
