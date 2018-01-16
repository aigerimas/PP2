using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace min_prime_number
{
    class Program
    {
        static public bool is_prime(int a)
        {
            for(int i = 2; i*i <= a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\admin\Desktop\KBTU\programming principles 2\week 2\min prime number\numbers.txt",FileMode.Open,FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();            
            string[] arr = line.Split(' ');
            int min = int.MaxValue;
            foreach(string str in arr)
            {
                
                if (is_prime(int.Parse(str)) && int.Parse(str) < min)
                {
                    min = int.Parse(str);
                    
                }
            }         
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("\nmin prime: {0}", min);
            sw.Close();
            sr.Close();
            fs.Close();
        }
    }
}
