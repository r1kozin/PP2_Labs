using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Rectangle
    {
        public double a;
        public double b;
        public double area;
        public double perimetr;
            public Rectangle()
        {
            a = 2;
            b = 3;
        }

        public Rectangle(double a,double b)
        {
            this.a = a;
            this.b = b;
            findArea();
            findPer();
        }
        public void findArea()
        {
            area = a * b;
        }
        public void findPer()
        {
            perimetr = (a + b) * 2;
        }
        public override string ToString()
        {
            return "perimetr = "+perimetr + "\narea = "+area;
        }
    }

}
