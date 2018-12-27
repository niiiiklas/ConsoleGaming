﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Entities
{
    public class GridPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GridPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
