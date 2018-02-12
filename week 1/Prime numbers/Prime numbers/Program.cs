using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)  
            {
                if (Is_simple(int.Parse(s)))
                
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        public static bool Is_simple(int a) 
        {
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

    }
}
