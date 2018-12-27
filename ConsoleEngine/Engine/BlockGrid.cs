using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleEngine.Engine
{
    public class BlockGrid : IGrid
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Block> Blocks = new List<Block>();

        public BlockGrid(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public void Render()
        {
            for(int row = 0; row < Height; row++)
            {
                for (int subRow = 0; subRow < Blocks.First().WH.H; subRow++)
                {
                    foreach(Block b in Blocks.Skip(row*Width).Take(Width))
                    {
                        foreach(var blockChar in b.Chars.Skip(subRow*b.WH.W).Take(b.WH.W))
                        {
                            Console.ForegroundColor = blockChar.Color;
                            Console.Write(blockChar.Character);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    public static class BlockGridFactory
    {
        public static BlockGrid Variant1()
        {
            int w = 32;
            int h = 16;

            var bg = new BlockGrid(w, h);

            for(int x = 0; x < w; x++)
            {
                for(int y= 0; y < h; y++)
                {
                    ConsoleColor ccc = ConsoleUtil.ConsoleColorRng.Any();
                    bg.Blocks.Add(new Block()
                    {
                        Pos = new GridPosition(x, y),
                        Chars = Var2Chars(ccc),
                        WH = new WiHe(3,2)
                    });
                }
            }
            return bg;
        }

        public static ColorChar[] Var1Chars(bool isRed)
        {

            var color = isRed ? ConsoleColor.Red : ConsoleColor.Green;
            return new ColorChar[]
            {
                new ColorChar()
                {
                    Character = '#',
                    Color = color
                },
                new ColorChar()
                {
                    Character = '#',
                    Color = color
                },
                new ColorChar()
                {
                    Character = '#',
                    Color = color
                },
                new ColorChar()
                {
                    Character = '#',
                    Color = color
                }
            };
        }

        public static ColorChar[] Var2Chars(ConsoleColor color)
        {
            var res = new List<ColorChar>();

            for(int i = 0; i < 6; i++)
            {
                res.Add(new ColorChar() { Color = color, Character = '#' });
            }

            return res.ToArray();
        }
    }
}
