using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private int width;
        private int height;
        public Rectangle(int width = 0, int height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public int FindArea()
        {
            return width * height;
        }
        public int FindPerimeter()
        {
            return 2 * (width + height);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            int S = rectangle.FindArea();
            int P = rectangle.FindPerimeter();
            Console.WriteLine("area: {0}\nperimeter: {1}", S, P);
            Console.ReadKey();
        }
    }
}
