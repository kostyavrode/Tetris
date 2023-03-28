using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 2;
            int y1 = 3;
            char c1 = '^';


            Square square = new Square(x1, y1, c1);
            square.Draw();
            square.Hide();
            square.Move(Direction.LEFT);

            square.Draw();
            Console.ReadLine();
        }
    }
}
