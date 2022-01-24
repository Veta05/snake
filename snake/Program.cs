using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;
using System.IO;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
		private const int MapWidth = 100;
		private const int MapHeight = 25;
		public const ConsoleColor BorderColor = ConsoleColor.Cyan;
        static void Main(string[] args)
		{
            //Sounds.Play();
			//Gamer.gamerName();

			SetWindowSize(MapWidth, MapHeight);
			SetBufferSize(MapWidth, MapHeight);
			CursorVisible = false;

			Walls walls = new Walls(80, 25);
			Console.ForegroundColor = ConsoleColor.Magenta;
			walls.Draw();

			HorizontalLine upline = new HorizontalLine(0, 78, 0, '♥');
			HorizontalLine downline = new HorizontalLine(0, 78, 24, '♥');
			VerticalLine leftline = new VerticalLine(0, 24, 0, '♥');
			VerticalLine rightline = new VerticalLine(0, 24, 78, '♥');
			upline.Drow();
			downline.Drow();
			leftline.Drow();
			rightline.Drow();


			Point p = new Point(4, 5, '↔');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Drow();

			FoodCreator foodCreator = new FoodCreator(80, 25, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
					Gamers.Rate();

				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			GameOver.WriteGameOver();
			Results.Result();
		}

	}
}
