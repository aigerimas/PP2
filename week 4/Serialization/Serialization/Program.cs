using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlExample
{
    [Serializable]
    public class Complex
    {
        public int a;
        public int b;
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
    class Program
    {        
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 1);
            Complex c2 = new Complex(3, 1);
            Complex c3 = c1 + c2;
            FileStream fs = new FileStream(@"C:\Users\Admin\Desktop\data1.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            try
            {
                xs.Serialize(fs, c3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            fs = new FileStream(@"C:\Users\Admin\Desktop\data1.xml", FileMode.Open, FileAccess.Read);            
            try
            {
                Complex s = xs.Deserialize(fs) as Complex;

                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            //_____________________________________________________________________________//
            fs = new FileStream(@"C:\Users\Admin\Desktop\dat.ser", FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(fs, c3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

            fs = new FileStream(@"C:\Users\Admin\Desktop\dat.ser", FileMode.Open, FileAccess.Read);            
            try
            {
                c3 = bf.Deserialize(fs) as Complex;

                Console.WriteLine(c3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            Console.ReadKey();
        }
    }
}
