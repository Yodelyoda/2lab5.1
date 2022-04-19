using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_5._1
{
    class Fraction
    {
        private long c;
        private int d;
        public Fraction()
        {
            c = 0;
            d = 0;
        }
        public Fraction(long c, int d)
        {
            this.c = c;
            this.d = d;
        }
        public Fraction(Fraction c)
        {
            this.c = c.c;
            this.d = c.d;
        }
        public void SetC(long c)
        {
            this.c = c;
        }
        public void SetD(int d)
        {
            this.d = d;
        }
        public long GetC()
        {
            return this.c;
        }
        public int GetD()
        {
            return this.d;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.c + b.c, a.d + b.d);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.c / b.c, a.d / b.d);
        }
        public static Fraction operator %(Fraction a, Fraction b)
        {
            return new Fraction(a.c % b.c, a.d % b.d);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            long c1 = a.c;
            int d1 = a.d;
           long c2 = b.c;
            int d2 = b.d;
        
            return new Fraction(c1/2,d1/2);
        }
        public static Fraction operator ^(Fraction a, UInt32 n)
        {
            
            var y = new Fraction(1, 0);
            for (UInt32 i = 1; i <= n; i++)
             y = y * a;
            return y;
        }
        
        public override string ToString()
        {
            return " long: " + this.c + "\n shor: " + this.d;
        }
    }
}
