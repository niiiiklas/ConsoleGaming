using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest1.Entities
{
    public class Wall : Block
    {
        public Wall(int posX, int posY) : base (posX, posY, Spec.BLOCK_W, Spec.BLOCK_H)
        {
            SetAllChars('#', ConsoleColor.White);
        }
    }
}
