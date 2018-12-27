using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Engine
{
    public class Grid : IGrid
    {
        public ColorChar[][] MapArea
        {
            get; set;
        }

        public void Render()
        {
            for (int x = 0; x < MapArea.Length - 1; x++)
            {
                for (int y = 0; y < MapArea[x].Length; y++)
                {
                    var cc = MapArea[x][y];
                    Console.ForegroundColor = cc.Color;
                    Console.Write(cc.Character);
                }
                Console.WriteLine();
            }
        }

        public void Init(int x, int y, ConsoleColor defaultColor)
        {
            MapArea = new ColorChar[x][];
            for (int i = 0; i < x; i++)
            {
                MapArea[i] = new ColorChar[y];
                for (int ii = 0; ii < y; ii++)
                {
                    MapArea[i][ii] = new ColorChar()
                    {
                        Character = '#',
                        Color = defaultColor
                    };
                }
            }

        }
    }
}
