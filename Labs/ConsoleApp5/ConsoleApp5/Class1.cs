using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    { 
        public bool IsPrime(int x)
        {
            int k = 0;
            for(int i=1;i<=Math.Sqrt(x);i++)
            {
                if (x % i == 0)
                {
                    k++;
                }
                if (k > 2)   return false;
                else return true;
            }
        }


    }
}
