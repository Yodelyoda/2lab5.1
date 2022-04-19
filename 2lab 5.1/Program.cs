using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_5._1
{
    internal class Program
    {
        public static void Main()
        {
            var a = new Fraction(1, 1);
            var b = new Fraction(1, 1);
            var g = new Fraction(1, 1);
            Console.WriteLine(a);

            Console.WriteLine("cila chastina: ");
            long c = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("drova chastina: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Fraction x = new Fraction(c, d);
            Fraction y = new Fraction();
            Console.WriteLine("vidnimania: ");
            y = x - b;
            String y1 = y.ToString();
            Console.WriteLine("Result: x-b =", y1);
            Console.WriteLine("parnist i ostaca: ");
            y = x % b;
            String y2 = y.ToString();
            Console.WriteLine("Result: x % b =", y2);
            if (y != a)
            {
                Console.WriteLine("Result: x i b parni");
            }
            else
            {
                Console.WriteLine("Result: x i b ne parni");
            }
            Console.WriteLine("dilenia: ");
            y = x / b;
            String y3 = y.ToString();
            Console.WriteLine("Result: x/b =", y3);
            Console.WriteLine("Pidnesenia: ");
            y = x ^ 2;
            String y4 = y.ToString();
            Console.WriteLine("Result: x^b =", y4);
            Console.ReadKey();
        }
    }
}
