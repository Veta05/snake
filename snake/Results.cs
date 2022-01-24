using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Results
    {
        public static void Result()
        {

            int xOffset = 30;
            int yOffset = 6;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Results", xOffset + 1, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Text.WriteText("Point Name", xOffset, yOffset++);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Gamers.ShowRate(xOffset, yOffset++);

        }
    }
}
