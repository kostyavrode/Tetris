using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            symbol = sym;
        }
        public Point()
        {

        }
        public void Draw()
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.DOWN:
                    y+= 1;
                    break;
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGHT:
                    x += 1;
                    break;
            }
        }
        public void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" "); 
        }
    }
}
