using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs  = new FileStream(@"C:\Users\admin\Desktop\KBTU\programming principles 2\week 2\Max and min\numbers.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] str = line.Split(' ');
            Console.Write("max: {0}, min: {1}", str.Max(), str.Min());
            Console.ReadKey();
        }
    }
}
