using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Stack
{
    class Program
    {
        static public void TreeFiles(string root, int path = 0)
        {
            Stack<string> dirs = new Stack<string>();
            dirs.Push(root);
            while (dirs.Count != 0)
            {
                string current = dirs.Pop();
                string[] subDirs = Directory.GetDirectories(current);
                string[] files = Directory.GetFiles(current);
                DirectoryInfo dir = new DirectoryInfo(current);
                Console.WriteLine(dir.Name);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    Console.WriteLine(fi.Name);
                }
                foreach (string str in subDirs)
                {
                    dirs.Push(str);
                }
                path += 5;
            }
        }

        static void Main(string[] args)
        {
            string root = @"C:\Users\admin\Desktop\root";
            TreeFiles(root);
            Console.ReadKey();
        }
    }
}
