using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public bool is_polindrom(string str)
        {
            bool b = true;
            for(int i = 0; i < str.Length/2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    b = false;
            }
            // 1221
            return b;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Admin\Desktop\input.txt", FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(@"C:\Users\Admin\Desktop\output.txt", FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            StreamReader sr = new StreamReader(fs);            
            int b = int.Parse(sr.ReadLine());
       
            for (int i = 1; i <= b; i++)
            {
                if(b % i == 0)
                {
                    sw.WriteLine(i);
                }
            }
            sw.Close();
            sr.Close();
            fs.Close();
            fs2.Close();
            Console.ReadKey();
        }
    }
}
