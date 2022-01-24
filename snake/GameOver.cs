using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snake
{
    class GameOver
    {
        public static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 7;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            Text.WriteText("G A M E    O V E R", xOffset + 1, yOffset++);


            Gamers gamers = new Gamers();

            Text.WriteText("Your score " + Gamers.rate, xOffset + 5, yOffset++);


            while (true)
            {
                try
                {

                    Text.WriteText("Your name: ", xOffset + 5, 10);
                    Console.SetCursorPosition(43, 10);
                    string playername = Console.ReadLine();
                    int sym = 3;
                    if (sym <= playername.Length)
                    {
                        Gamers.ScoresSave(playername, Gamers.rate);
                        break;
                    }
                    else
                    {
                        throw new LengthException();
                    }
                }
                catch (LengthException)
                {
                    Text.WriteText("                                        ", xOffset, 10);
                    Text.WriteText("Enter your name please, where is minimum 3 sympols: ", xOffset - 8, 11);
                }

            }
        }
    }
}

