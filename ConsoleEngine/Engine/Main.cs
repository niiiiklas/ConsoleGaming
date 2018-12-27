using ConsoleEngine.Engine.Extensions;
using ConsoleEngine.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.Engine
{
    public class Main
    {
        public IGrid grid { get; set; }

        public void Render()
        {
            grid.Render();
        }
    }
}
