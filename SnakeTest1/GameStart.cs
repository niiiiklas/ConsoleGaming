using ConsoleEngine.Engine;
using ConsoleEngine.Entities;
using System;

namespace SnakeTest1
{
    public class GameStart
    {



        static void Main(string[] args)
        {
            Console.WriteLine();

            var m = new ConsoleEngine.Engine.Main()
            {
                grid = Initializers.InitGrid(),
            };

            m.RenderTest();
            //m.Start();

            Console.ReadLine();
        }
    }

    class Initializers
    {
        public static BlockGrid InitGrid()
        {
            string path = "./maps/map0.txt";
            return ConsoleEngine.Util.BlockGridFromFile.Parse(path, 
                (char c, GridPosition pos) =>
                {
                    switch(c)
                    {
                        case '1':
                            return new Entities.Wall(pos.X, pos.Y);
                        case '0':
                            return new Entities.Empty(pos.X, pos.Y);
                        case 'P':
                            return new Entities.PlayerBlock(pos.X, pos.Y);
                        default:
                            throw new NotImplementedException("Missing map character...");
                    }
                });
        }
    }
}
