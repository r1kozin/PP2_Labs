using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxmin = System.IO.File.ReadAllText(@"D:\Rus\PP2_Labs\Labs\MaxMin\ConsoleApp1\text.txt");
            string[] s = maxmin.Split(' ');
            int min, max;
            min = int.Parse(s[0]);
            max = int.Parse(s[0]);
            int number;
            for (int i = 0; i < s.Length; i++)
            {
                number = int.Parse(s[i]);
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
