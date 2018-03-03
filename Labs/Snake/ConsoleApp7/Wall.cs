using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Wall
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

       

        public void LoadLevel(int level)
        {


         
            FileStream fs = new FileStream(@"D:\Rus\PP2_Labs\Labs\Snake\ConsoleApp7\"+"level1"+".txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
            }
            sr.Close();
        }
        public Wall(int level)
        {
            body = new List<Point>();
            sign = '#';
            color = ConsoleColor.Magenta;
            LoadLevel(level);
        }




        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}







