using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Food
    {
        public Point location;
        public char sign;
        public ConsoleColor color;
        public Food()
        {
            sign = '@';
            color = ConsoleColor.Yellow;
            SetRandomPosition();
        }
        public void SetRandomPosition()
        {   
            int x = new Random().Next(2, 49);
            int y = new Random().Next(3, 19);
            location = new Point(x, y);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(location.x, location.y);
            Console.WriteLine(sign);
        }
    }
}
