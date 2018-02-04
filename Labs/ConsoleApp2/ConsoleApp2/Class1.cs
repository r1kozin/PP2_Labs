using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    
    {
        public double radius;
        public double area;
    }
    public void findArea()
    {
        area = Math.PI * radius * radius;
    }
    public override string ToString()
    {
        return "radius = " + radius + "\narea = " + area;
    }


}
