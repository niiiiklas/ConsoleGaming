using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Engine.Extensions
{
    public static class GridExtensions
    {
        public static void ForEach(this Grid grid, Action<ColorChar> act)
        {
            for (int x = 0; x < grid.MapArea.Length - 1; x++)
            {
                for (int y = 0; y < grid.MapArea[x].Length; y++)
                {
                    act(grid.MapArea[x][y]);   
                }
            }
        }
    }
}
