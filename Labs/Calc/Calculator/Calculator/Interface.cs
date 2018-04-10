using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Interface 
    {
        public double a = 0;
        public double memory = 0;
        
        public void MemorySave(double b)
        {
            memory = b;
        }
        public double MemoryShow()
        {
            return memory;
        }
        
        public void Memory_Clear()
        {
            memory = 0;
        }
        public void M_Sum(double b)
        {
            memory += b;
        }
        public void M_Minus(double b)
        {
            memory -= b;
        }


    }
}
