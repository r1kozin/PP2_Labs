using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[]a = s.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                int t = int.Parse(a[i]);
                bool k = true;
                if (t == 1)
                {
                    continue;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(t); j++)
                    {
                        if (t % j == 0)
                        {
                            k = false;
                        }
                    }
                    if (k == true)
                    {
                        Console.Write(a[i] + ' ');

                    }
                }
            }
            Console.ReadKey();
        }
    }
}
