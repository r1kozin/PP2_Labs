using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Snake
    {
        public int cnt=0;
        public List<Point> body;
        public char sign;
        public ConsoleColor color;
        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Cyan;
            body = new List<Point>();

            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
        }

        public void Move(int dx, int dy)
        {
            Point lastPoint = body[body.Count - 1];
            Console.SetCursorPosition(lastPoint.x, lastPoint.y);
            Console.Write(' ');
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;
            if (CanEat())
            {
                cnt++;
                Game.food.SetRandomPosition();

                
            }

        }

        public bool CanEat()
        {
            if (Game.food.location.x == body[0].x && Game.food.location.y == body[0].y)
            {

                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                
               
                
                return true;
               
            }
            return false;
        }
        public bool CollisionWithWall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }

        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }
        public void Draw()
        {
            int i = 0;
            foreach (Point p in body)
            {
                if (i == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
    }
}



        