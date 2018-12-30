using ConsoleEngine.Engine;
using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleEngine.Util
{
    public static class BlockGridFromFile
    {

        public static BlockGrid Parse(string path, Func<char, GridPosition, Block> parser)
        {

            var lines = File.ReadAllLines(path);
            int w = lines[0].Length;
            int h = lines.Length;
            var bg = new BlockGrid(w, h);

            bg.Blocks.Clear();

            for(int y = 0; y < lines.Length; y++)
            {
                for(int x = 0; x < lines[y].Length; x++)
                {
                    char c = lines[y][x];
                    bg.Blocks.Add(parser(c, new GridPosition(x, y)));
                }
            }

            foreach(char c in lines.SelectMany(x => x))
            {
                
            }
            
            return bg;
        }
    }
}
