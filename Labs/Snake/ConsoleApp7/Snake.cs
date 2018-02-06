using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Snake
    {
        List<Point> body;
        public string sign;
        ConsoleColor  color;
        public int cnt;
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            sign = "*";
            color = ConsoleColor.Magenta;
            cnt = 0;
        }
      public void Move(int dx, int dy)
        {
           
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;

            }
            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 1;
            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }
        public bool CanEatFood(Food food)
        { if (food.location.x == body[0].x && food.location.y == body[0].y)
            {
                body.Add(new Point(body[body.Count-1].x, body[body.Count-1].y));
                return true;
            }
            return false;

            

        }
        public void Draw()
        {
            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                else
                    
                Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine(sign);
            }
        }
    }
}
