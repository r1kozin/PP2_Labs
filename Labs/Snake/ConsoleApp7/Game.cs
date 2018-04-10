using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
   
    class Game
    {
        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public static bool GameOver;

        public static void Init()
        {
            GameOver = false;
            Console.CursorVisible = false;
           
            int level = 1;
            snake = new Snake();
            food = new Food();
            wall = new Wall(level);

           
            }

        public static void Draw()
        {
           
            snake.Draw();
            food.Draw();
            wall.Draw();

        }
         

    }

}
