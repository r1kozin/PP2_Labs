using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int proz = 1
                ;
            for (int i = 0; i <n; i++)
            {
                proz = 2 * proz;
            }
            Console.WriteLine(proz);
            Console.ReadKey();

        }
    }
}
