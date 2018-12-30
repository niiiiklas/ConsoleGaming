using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Entities
{
    public class Block
    {
        public GridPosition Pos { get; set; }

        public ColorChar[] Chars { get; set; }

        public WiHe WH { get; set; }

        public static Block Create(int posX, int posY, int width, int height)
        {
            return new Block(posX, posY, width, height);
        }

        public Block(int posX, int posY, int width, int height)
        {
            Pos = new GridPosition(posX, posY);
            Chars = new ColorChar[width * height];
            WH = new WiHe(width, height);
        }

        public void SetAllChars(char c, ConsoleColor col)
        {
            for (int i = 0; i < Chars.Length; i++)
                Chars[i] = new ColorChar()
                {
                    Character = c,
                    Color = col
                };
        }
    }
}
