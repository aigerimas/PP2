using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        class Point
        {
            int x;
            int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public override string ToString()
            {
                return "x: " + x.ToString() + "y: " + y.ToString();
            }
        }
        static void Main(string[] args)
        {
            Point point = new Point(3, 4);
            Console.Write(point);
            Console.ReadKey();
        }
    }
}
