using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki
{
    internal class RownanieKwadratowe
    {
        private int a, b, c;

        public RownanieKwadratowe(int a, int b, int c) 
        {
            this.a = a; this.b = b; this.c = c;
        }
        public int ObliczDelte()
        {
            return b*b - 4 * a * c;
        }
        public double[] ObliczRozwiazanie()
        {
            int delta = ObliczDelte();
            if (delta < 0)
            {
                throw new Exception("delta < 0");
            }
            else if (delta > 0) 
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (delta == 0)
            {
                double x = -b / 2 * a;
                return new double[] { x, x };
            }
            return new double[] {0,0};
        }
    }
}
