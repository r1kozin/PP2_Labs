using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] s = text.Split(' ');
            string[] n1 = s[0].Split('/');
            string[] n2 = s[1].Split('/');
            int a = int.Parse(n1[0]);
            int b = int.Parse(n1[1]);
            int c = int.Parse(n2[0]);
            int d = int.Parse(n2[1]);

            complex c1 = new complex(a, b);
            complex c2 = new complex(c, d);
            complex sum = c1 + c2;
            complex dif = c1 - c2;
            complex prod = c1 * c2;
            complex div = c1 / c2;

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(prod);
            Console.WriteLine(div);

            Console.ReadKey();

        }
    }
}
    