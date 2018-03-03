using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Complex
    {
        public int a, b;

        public Complex()
        {
            a = 1;
            b = 6;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
