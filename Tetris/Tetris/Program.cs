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


            Drow(x1, y1, c1);
            Console.ReadLine();
        }
        static void Drow(int x,int y,char symbol)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }
    }
}
