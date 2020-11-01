using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class Calculator
    {
        public int NB1 = 0;
        public int NB2 = 0;

        public Calculator() { }

        public Calculator(int nb1, int nb2)
        {
            NB1 = nb1;
            NB2 = nb2;
        }

        public static int operator + (Calculator val1, Calculator val2)
        {
            int total = val1 + val2;
            return total;
        }

        public static int operator - (Calculator val1, Calculator val2)
        {
            int total = val1 - val2;
            return total;
        }

        public static double operator / (Calculator val1, Calculator val2)
        {
            double total = val1 / val2;
            return total;
        }

        public static int operator *(Calculator val1, Calculator val2)
        {
            int total = val1 * val2;
            return total;
        }
    }
}
