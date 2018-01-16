using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        class Complex
        {
            int a;
            int b;
            public Complex() { }
            public Complex(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public static Complex operator +(Complex c1, Complex c2)
            {
                int lcm = Math.Max(c1.b, c2.b);
                bool b = true;
                while (b)
                {
                    if (!(lcm % c1.b == 0 && lcm % c2.b == 0))
                        lcm++;
                    else
                        b = false;
                }
                int numerator = lcm / c1.b * c1.a + lcm / c2.b * c2.a;
                Complex c = new Complex(numerator, lcm);
                return c;
            }
            public override string ToString()
            {
                return a + "/" + b;
            }
        }
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Complex c2 = new Complex(3, 3);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);
            Console.ReadKey();
        }
    }
}
