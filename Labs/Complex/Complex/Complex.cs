using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class complex
    {
        public int a, b;
        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        public static complex operator +(complex c1, complex c2)
        {
            complex sum = new complex(c1.a * c2.b + c2.a * c1.b, c1.b * c2.b);
            sum.simplify();
            return sum;
        }
        public static complex operator -(complex c1, complex c2)
        {
            complex dif = new complex(c1.a * c2.b - c2.a * c1.b, c1.b * c2.b);
            dif.simplify();
            return dif;
        }

        public static complex operator *(complex c1, complex c2)
        {
            complex prod = new complex(c1.a * c2.a, c1.b * c2.b);
            prod.simplify();
            return prod;
        }
        public static complex operator /(complex c1, complex c2)
        {
            complex div = new complex(c1.a * c2.b, c1.b * c2.a);
            div.simplify();
            return div;
        }

        public void simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;

        }
    }
}

