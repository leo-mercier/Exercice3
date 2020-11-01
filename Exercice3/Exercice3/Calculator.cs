using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class Calculator
    {
        public int Numerateur { get; }
        public int Denominateur { get; }
        public Calculator(int numerateur, int denominateur)
        {
            Numerateur = numerateur;
            Denominateur = denominateur;
        }


        public static int operator +(int numerateur, int denominateur)
        {
            return numerateur + denominateur;
        }

        public static int operator /(int numerateur, int denominateur)
        {
            return numerateur / denominateur;
        }

        public static int operator -(int numerateur, int denominateur)
        {
            return numerateur - denominateur;
        }

        public static int operator *(int numerateur, int denominateur)
        {
            return numerateur * denominateur;
        }


    }
}
