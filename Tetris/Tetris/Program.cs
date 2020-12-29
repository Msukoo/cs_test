using System;
using System.Collections.Generic;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {



            TetrisScreen NewSC = new TetrisScreen(10, 15);

            Block NewBlock = new Block(NewSC);
            while (true)
            {
                Console.Clear();               
                NewSC.Render();
                NewSC.Clear();
                NewBlock.Move();
            }
            
        }
    }
}
