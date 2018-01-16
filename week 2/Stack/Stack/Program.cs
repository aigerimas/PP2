﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Stack
{
    class Program
    {
        static public void TreeFiles(string root)
        {
            Stack<string> dirs = new Stack<string>();
            dirs.Push(root);
            while (dirs.Count != 0)
            {
                string current = dirs.Pop();
                string[] subDirs = Directory.GetDirectories(current);
                string[] files = Directory.GetFiles(current);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    Console.WriteLine(fi.Name);
                }
                foreach (string str in subDirs)
                {
                    dirs.Push(str);
                }
            }
        }

        static void Main(string[] args)
        {
            string root = @"C:\Users\admin\Desktop\KBTU";
            TreeFiles(root);
            Console.ReadKey();
        }
    }
}
