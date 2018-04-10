using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace ConsoleApp7
{
    class Program
    { public static int level = 1;
        public static int direction = 1;
        public static int speed = 200;

        static void MoveSnakeThread(object state)
        {
            while (!Game.GameOver)
            {
                switch (direction)
                {
                    case 1:
                        Game.snake.Move(1, 0);
                        break;
                    case 2:
                        Game.snake.Move(0, 1);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(0, -1);
                        break;
                }
                Game.Draw(); //if (Game.snake.cnt % 20 == 0)
                    //speed = Math.Max(1, speed - 100);
                Thread.Sleep(speed);
               
                if (Game.snake.cnt >=0)
                {
                    Console.SetCursorPosition(2, 23);
                    Console.WriteLine("Score " + Game.snake.cnt);
                }

               
                    if (Game.snake.CollisionWithWall(Game.wall) || Game.snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey();

                    Game.snake = new Snake();
                    Game.wall = new Wall(1);
                }

            }



        }
     
        static void Main(string[] args)
        {
            Game.Init();

      
            Thread t = new Thread(MoveSnakeThread);
            t.Start();

            while (!Game.GameOver)
            {
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = 4;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = 2;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = 1;
                        break;
                }

             




            }




        }
    }
}
       

