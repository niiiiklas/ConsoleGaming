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

        public void RenderTest()
        {
            grid.Render();
        }

        public void Start()
        {

            while(true)
            {
                grid.Render();

                Input();
            }
        }

        public void Input()
        {
            var inp = Console.Read();
            Console.WriteLine("In: " + inp);
        }
    }
}
