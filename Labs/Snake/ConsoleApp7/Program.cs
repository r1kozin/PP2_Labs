using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Snake snake = new Snake();
            Food food = new Food();
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                 if (keyInfo.Key == ConsoleKey.UpArrow)
                    snake.Move(0, -1);
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    snake.Move(0, 1);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    snake.Move(-1, 0);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    snake.Move(1, 0);

                if (snake.CanEatFood(food))
                {
                    food.SetRandomPosition();
                }
                Console.Clear();

                snake.Draw();
                food.Draw();
            }
        }
    }
}
