using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public double FindArea()
        {
            return Math.PI * radius * radius;
        }
        public double FindPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            double S = circle.FindArea();
            double P = circle.FindPerimeter();
            Console.Write("area: {0}\nperimeter: {1}", S, P);
            Console.ReadKey();
        }
    }
}
