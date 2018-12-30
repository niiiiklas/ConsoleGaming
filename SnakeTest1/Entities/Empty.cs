using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeTest1.Entities
{
    public class Empty : Block
    {
        public Empty(int posX, int posY) : base (posX, posY, Spec.BLOCK_W, Spec.BLOCK_H)
        {
            SetAllChars(' ', ConsoleColor.Black);
        }
    }
}
