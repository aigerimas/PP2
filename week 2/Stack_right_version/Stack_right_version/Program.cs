using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_right_version
{    
    class Program
    {
        static public void ShowDirectories(string path, int space = 0)
        {
            Stack<DirectoryInfo> stack = new Stack<DirectoryInfo>();
            DirectoryInfo root = new DirectoryInfo(path);
            stack.Push(root);
            DirectoryInfo[] dirs = root.GetDirectories();
            foreach (DirectoryInfo d in dirs)
            {
                for (int i = 0; i < space; i++)
                    Console.Write(' ');
                space += 5;
                Console.Write(d.Name);
                Console.WriteLine();
                stack.Push(d);
            }
            for (int i = 0; i < stack.Count; i++)
            {
                DirectoryInfo cur = stack.Pop();
                FileInfo[] fl = cur.GetFiles();
            }
        }
        static void Main(string[] args)
        {
            string path = @"D:\Filmes";
            ShowDirectories(path);
            Console.ReadKey();
        }
    }
}
