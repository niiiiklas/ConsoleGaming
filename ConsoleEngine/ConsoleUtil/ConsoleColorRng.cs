using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEngine.ConsoleUtil
{
    public static class ConsoleColorRng
    {
        private static Random RNG = new Random();

        public static ConsoleColor Any()
        {
            var arr = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor) arr.GetValue(RNG.Next(arr.Length));
        }
    }
}
